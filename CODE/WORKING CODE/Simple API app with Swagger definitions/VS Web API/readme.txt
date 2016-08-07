- Use Visual Studio to create a web API app using the ASP.Net framework
- Create some hardcoded data in the controller (such as some barcodes)
- Install the Swashbuckle NuGet package
- Uncomment the below from the SwaggerConfig.cs file in the App_Start folder:
	})
                .EnableSwaggerUi(c =>
                    {
- Run it locally or deploy it on Azure
- Append /swagger in the URL to get the Swagger API testing UI
- Use the link in the top of the page to downlonad the Swagger API (ex. http://localhost:59533/swagger/docs/v1)