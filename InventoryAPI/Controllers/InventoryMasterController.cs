using System.Linq;
using System.Net;
using System.Web.Http;
using Inventory.Entities;
using Inventory.Services;
using System.Web;
using Newtonsoft.Json;
using System.IO;
using System;
using System.Web.Http.Cors;

namespace InventoryAPI.Controllers
{
    [EnableCors(origins:"*", headers:"*", methods:"*")]
    [RoutePrefix("api/inventoryApp")]
    public class InventoryMasterController : ApiController
    {
        private readonly IInventoryMaster _inventoryMasterService = null;

        public InventoryMasterController(IInventoryMaster inventoryMasterService)
        {
            this._inventoryMasterService = inventoryMasterService;
        }

        [Route("GetInventoryItems")]
        [HttpGet]
        public IHttpActionResult GetInventoryMasterItems()
        {
            try
            {
                var inventoryItems = _inventoryMasterService.GetInventoryMasters();
                return Content(HttpStatusCode.OK, inventoryItems.AsQueryable());
            }
            catch(Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [Route("GetInventoryItemById")]
        [HttpGet]
        public IHttpActionResult GetInventoryMasterItem(int ID)
        {
            try
            {
                InventoryMaster inventoryMasterItem = _inventoryMasterService.GetInventoryMasterItem(ID);
                if (inventoryMasterItem == null)
                {
                    return NotFound();
                }
                return Content(HttpStatusCode.OK, inventoryMasterItem);
            }
            catch(Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [Route("DeleteInventoryItem")]
        [HttpDelete]
        public IHttpActionResult DeleteInventoryItem(int ID)
        {
            try
            {
                InventoryMaster inventoryMasterItem = _inventoryMasterService.DeleteInventoryMaster(ID);
                if (inventoryMasterItem == null)
                {
                    return NotFound();
                }
                else
                {
                    var itemFilePath = HttpContext.Current.Server.MapPath("~/InventoryItemUpload/" + inventoryMasterItem.ItemFile);
                    if (File.Exists(itemFilePath))
                    {
                        File.Delete(itemFilePath);
                    }
                }
                return Content(HttpStatusCode.OK, inventoryMasterItem);
            }
            catch(Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [Route("SaveInventoryItem")]
        [HttpPost]
        public IHttpActionResult SaveInventoryItem()
        {
            try
            {
                var httpRequest = HttpContext.Current.Request;
                InventoryMaster objInventoryMaster = JsonConvert.DeserializeObject<InventoryMaster>(httpRequest.Form["data"]);

                if (objInventoryMaster != null && ModelState.IsValid)
                {
                    if (httpRequest.Files.Count > 0)
                    {
                        var postedItemFile = httpRequest.Files[0];
                        var itemFilePath = HttpContext.Current.Server.MapPath("~/InventoryItemUpload/" + postedItemFile.FileName);
                        postedItemFile.SaveAs(itemFilePath);
                    }
                    _inventoryMasterService.SaveInventoryMaster(objInventoryMaster);
                    return Ok();
                }
                else
                {
                    var msg = objInventoryMaster == null ? "Invalid Request" : (string.Join(" | ", ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage)) + string.Join(" | ", ModelState.Values.SelectMany(v => v.Errors).Select(e => e.Exception)));
                    return Content(HttpStatusCode.BadRequest, msg);
                }
            }
            catch(Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [Route("UpdateInventoryItem")]
        [HttpPost]
        public IHttpActionResult UpdateInventoryItem()
        {
            try
            {
                var httpRequest = HttpContext.Current.Request;
                InventoryMaster objInventoryMaster = JsonConvert.DeserializeObject<InventoryMaster>(httpRequest.Form["data"]);

                if (objInventoryMaster != null && ModelState.IsValid)
                {
                    if (httpRequest.Files.Count > 0)
                    {
                        var postedItemFile = httpRequest.Files[0];
                        var itemFilePath = HttpContext.Current.Server.MapPath("~/InventoryItemUpload/" + postedItemFile.FileName);
                        postedItemFile.SaveAs(itemFilePath);
                    }
                    _inventoryMasterService.UpdateInventoryMaster(objInventoryMaster);
                    return Ok();
                }
                else
                {
                    var msg = objInventoryMaster == null ? "Invalid Request" : (string.Join(" | ", ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage)) + string.Join(" | ", ModelState.Values.SelectMany(v => v.Errors).Select(e => e.Exception)));
                    return Content(HttpStatusCode.BadRequest, msg);
                }
            }
            catch(Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
