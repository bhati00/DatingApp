**first App in Agular**
*<li>we use interpolation {{}} to dynamically insert value from component class*
*<li>app.module.ts provides metadata that Angular needs to, we
*<li>add extension angular service*<br> 
 **Making Https request in Angular** 
*<li> Import the HttpClient module in your component*
*<li>Inject the HttpClient service in the constructor*
*<li>Use the http methods of the HttpClient service to make HTTP requests. These methods return an Observable that you can subscribe to in order to receive the response from the server:*<br>
**Adding cors support to API**<br>
CORS (Cross-Origin Resource Sharing) is a security feature implemented in web browsers to prevent a website or application from making unauthorized requests to another website or application
*<li> Add the service.AddCors middleware in the project.cs*
*<li> then add the app.UseCors middleware for the https pipeline*