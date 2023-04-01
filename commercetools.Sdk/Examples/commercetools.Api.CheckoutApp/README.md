# ME Endpoint Checkout App

This example application demonstrates how the ME endpoints can be used with the DotNET v2 SDK.

## Requirements

- A Composable Commerce Project with a configured [API Client](https://docs.commercetools.com/getting-started/create-api-client#create-an-api-client).
  - Your API Client must have the following scopes: `view_published_products`, `view_categories`, `manage_my_profile`, `manage_my_shopping_lists`, `manage_my_payments`, `manage_my_orders`
- Your Project must have existing Products containing Variants with SKUs, and at least one Customer.
  - If your Project is currently empty, you can install the [SUNRISE sample data](https://docs.commercetools.com/sdk/sunrise-data).

## Installation

1. Clone/Download the Repository contents.
2. Open **commercetools.Sdk\Examples\commercetools.Api.CheckoutApp** in CLI and run **dotnet build** command.
3. Open **appsettings.json** and replace the placeholder values with your API Client credentials.
4. Open **commercetools.Sdk\Examples\commercetools.Api.CheckoutApp** in **Visual Studio Code**.
5. Add debug configuration **Run** -> **Add Configuration** ->  **.NET 5+ and .NET Core**.
6. Start the app using **Run** > **Start Debugging** or by pressing **F5**.
7. A new web browser window opens and displays the Checkout app. A list of Products should appear.
