 **- Making Https request in Angular**
*1. Import the HttpClient module in your component*
*2.Inject the HttpClient service in the constructor*
*3.Use the http methods of the HttpClient service to make HTTP requests. These methods return an Observable that you can subscribe to in order to receive the response from the server:*

**- Adding cors support to API**
CORS (Cross-Origin Resource Sharing) is a security feature implemented in web browsers to prevent a website or application from making unauthorized requests to another website or application
*1. Add the service.AddCors middleware in the project.cs*
*2. then add the app.UseCors middleware for the https pipeline*