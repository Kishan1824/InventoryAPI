# InventoryAPI

## Inventory Management API Using Web API And MVC Frameworks.

[![Build Status](https://travis-ci.org/joemccann/dillinger.svg?branch=master)](https://travis-ci.org/joemccann/dillinger)

InventoryAPI is a open source web api repository.

## Features

- Add/Manage/Delete Inventory Items Using Web API.
- Test API Using Swagger UI.

## Tech

InventoryAPI uses a number of open source packages to work properly:

- [SwaggerUI] - visually render documentation for an API.
- [Asp.Net MVC] - easy to implement model binding & validation.
- [Wen API] - to implement basic functionlity of inventory add/manage/delete.

And of course InventoryAPI itself is open source with a public repository
on GitHub.

## Setup

1. Download the project from this repository.

2. Right-click on downloaded zip file. Click Properties. Check the checkbox for Unblock. Click Apply.

  You can skip this step if you are cloning the repository.

3. Open InventoryAPI.sln file via Visual Studio.

  Right-click on InventoryAPI.Database and select Set as Startup Project.

  Open Package Manager Console in Visual Studio (Tools > NuGet Package Manager > Package Manager Console).

  Make sure Default Project is selected as ShopBridge.Database in the Package Manager Console.

  Copy the below command and paste it in the Package Manager Console window.

PM > update-database

  NOTE : After pasting, hit Enter.

## Run Project

Right-click on InventoryAPI project. Click Set as Startup Project.
Run the project by pressing F5 in the keyboard.

## License

MIT
