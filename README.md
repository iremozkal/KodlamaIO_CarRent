# Rent A Car Project

Kodlama.io - Software Bootcamp.

### General info
The project consists of 5 layers: Entities, DataAccess, Business, Core, ConsoleUI and WebAPI.  
For each entity (car, brand, color, customer, user, rental, car image), there is a menu screen for related operations in ConsoleManager. Each operation is controlled by its own manager and the manager uses the Dal classes to implement crud operations. All data access layers implement generic IEntityRepository interface as a common outline.  
Autofac IoC Container is used for Dependency Injection and Aspect Oriented Programming. Validation is a Cross Cutting Concern and as 
regard of AOP, Validation Aspect is created with Autofac using Interceptors. FluentValidation is the Validation Tool used for the verification process.


## Technologies  

| _**present - v2.0**_ | _**v1.0 - v1.8**_ |
| -- | -- |
| Visual Studio 2019 | Visual Studio 2012 |
| Asp.Net Core 3.1 | .Net Framework 4.5 |
| EntityFrameworkCore.SqlServer 3.1.11 | EntityFramework 6.4.4 |
| FluentValidation 9.5.1 | FluentValidation 7.1.1 |
| Autofac 6.1.0 &  Autofac.Extras.DynamicProxy 6.0.0 | Unity 5.7.3 |


+ In early versions, Web Api Layer is created as a ASP.NET WebAPI 2 Project. Unity has been used for dependency injection. UnityResolver class registers the type-mapping with the container, 
so that it can create the correct object for the given type. After that, it automatically injects the dependencies using the resolve() method. Web Api Layer resolves the dependency of the Business Layer in WebApiConfig class with setting of the dependency resolver.  

+ Currently, Wep Api Layer uses Autofac for dependency injection. It boots the AutofacBusinessModule that registers all necessary services in the Business Layer. Autofac is faster, smaller and easier to use compared to Unity. IActionResult could not be used in the old WebApi Controllers. We could return IHttpActionResult or HttpResponseMessage instead. 


### Other Camp Works
[repl.it/@iiremozkal](https://repl.it/@iiremozkal)
