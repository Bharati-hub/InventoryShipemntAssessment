# InventoryShipmentManagementSystem

## Overview
The `InventoryShipmentManagementSystem` project is built using the .NET 8 framework. It is designed to manage inventory and shipments. This project includes the `ProductService` class and the `ShipmentService` class.

## Features
- **DataGrid Usage**: 
  - Used two DataGrids to display product and shipment data, organized with tabs.
- **CRUD Operations**: 
  - Implemented buttons for Insert, Clear, Update, and Delete operations.
- **API Interaction**: 
  - Used a free dummy API for loading data. Note: Saving data with the dummy API is not supported.

## Basic Implementation
- **In-Memory Storage**: 
  - Utilized in-memory runtime objects to store and manage product data.
- **CRUD Operations**: 
  - Implemented basic CRUD operations within the service layer.

## Basic Testing
- **Unit Testing**: 
  - Performed NUnit testing for individual CRUD operation methods in the backend service.

## Limitation
- **API Limitation**: 
  - Used a dummy API for loading data, which does not support saving data.

## Getting Started

### Prerequisites
- .NET 8 SDK
- Visual Studio or any other C# IDE


### Installation--- click on share link and open the Solution:

Open the InventoryShipmentManagementSystem.sln file in Visual Studio.
Restore Dependencies:

In Visual Studio, go to Tools > NuGet Package Manager > Package Manager Console.
Run the following command to restore dependencies:dotnet restore
Build the Solution
Run the Application
