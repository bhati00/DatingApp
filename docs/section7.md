**Error Handling Middleware**
*allows developers to handle exceptions that occur during the execution of an application. It acts as a layer between the application code and the runtime environment*
1.> first create a ApiExceptions file in the error folder.
2.> then create a middleware in the middleware folder which would have file exceptionmiddleware , we would use this middleware in the program.cs file. 

**Testing Errors in the client**
create a error component

**Adding Error Interceptor**
*INTERCEPTOR: interceptor is a middleware that intercepts HTTP requests and responses. It can be used to perform tasks such as modifying headers, logging, error handling, caching, and more.*
*interceptor uses the HttpHandler class to handle the HTTP request and response. It then uses the pipe() method to modify the behavior of the request and response by chaining observable operators.*

**we'll create the seperate error handling componenets for not found and server error**