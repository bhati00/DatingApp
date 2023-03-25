**Safe storage of passwords**
*a) using hasing ,using var hmac = new HMACSHA512()*
*b)using hashing and salting(adds an extra value to the password before hashing)*

**create a BaseApiController**
*it will help us to write resuable code , testing, consistency*
**Using a Debugger**
*set  a breakpoint and attach it , then start the debugger*

**WHY WE CREATE THE DTO's**
 * encapsulate the data being transferred, ensure the format that is appropriate for the receiving client or server
 * domain models may contain sensitive information

**Adding the validation**
*-validating the data in DTOs, you can ensure that the input received from the client is valid and meets the business requirements*
*-when you put validations in the DTO, they are checked by the API controller when it receives data from the client*
*-by putting validations in DTOs instead of entities in .NET Web API, you can achieve separation of concerns, reusability, security, flexibility, and performance*

**creating endpoint login**
*create a dto logindto and then create a post method for the login which compares the computed hash of input password and stored hash of the user*
**JSON web tokens**
*a standard for securely transmitting information between parties as a JSON object. It is commonly used in web applications as a way to authenticate and authorize users.*

**WHY JWT  TOKENS NEDDED :**
* Unlike traditional session-based authentication, which requires the server to store session data for each user, JWT is stateless
* Cross-domain, Standardized, Security.

*<u>Steps to create jwt token</u>*
-->first create a interface and then it's service class , then register the service dependency injection 
-->Read a secret key from an external configuration file(program.cs) or source using IConfiguration.
-->Create a new SymmetricSecurityKey object with the secret key.
-->Create a method named CreateToken that takes an AppUser instance as input and returns a JWT as a string.
-->Create a list of claims with a single claim containing the AppUser's UserName.
-->Create a new SigningCredentials object with the SymmetricSecurityKey and a signature algorithm (HmacSha512Signature).
-->Create a new SecurityTokenDescriptor object with the list of claims, an expiration time (7 days from the current time), and the SigningCredentials object.
-->Create a new JwtSecurityTokenHandler object.
-->Call the CreateToken method on the JwtSecurityTokenHandler, passing in the SecurityTokenDescriptor object created earlier. This returns a new JWT.
-->Call the WriteToken method on the JwtSecurityTokenHandler, passing in the new JWT. This returns the JWT as a string.

**registers a service dependency injection in program.cs**
*Once you've registered the service with the dependency injection container using the AddScoped method , you can use it in your application by injecting it into your classes or controllers that require it.*

**Adding the Authentication middleware**
-->Install the  Microsoft.AspNetCore.Authentication.JwtBearer for JWT authentication.
-->use the UseAuthentication and UseAuthorization extension methods to add the middleware. The UseAuthentication middleware should be added before the UseAuthorization middleware.
**adding the extension method : set the class as static**