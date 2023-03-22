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
