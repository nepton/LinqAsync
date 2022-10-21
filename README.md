# Thingsboard.Net
[//]: # ([![Build status]&#40;https://ci.appveyor.com/api/projects/status/6yuxsfe71po3ofqg?svg=true&#41;]&#40;https://ci.appveyor.com/project/nepton/thingsboard-net&#41;)
![GitHub issues](https://img.shields.io/github/issues/nepton/linq-async.svg)
[![GitHub license](https://img.shields.io/badge/license-MIT-blue.svg)](https://github.com/nepton/linq-async/blob/master/LICENSE)

This package allow you to do the asynchronous query with IQueryable.
Implements async query interface IAsyncQueryableMethodsProvider for your code.

**All client API are tested in Thingsboard v3.4.x**

## Nuget packages
| Name             | Version                                                                                                           | Downloads                                                                                                          |
|------------------|-------------------------------------------------------------------------------------------------------------------|--------------------------------------------------------------------------------------------------------------------|
| LinqAsync        | [![nuget](https://img.shields.io/nuget/v/LinqAsync.svg)](https://www.nuget.org/packages/LinqAsync/)               | [![stats](https://img.shields.io/nuget/dt/LinqAsync.svg)](https://www.nuget.org/packages/LinqAsync/)               |
| LinqAsync.EFCore | [![nuget](https://img.shields.io/nuget/v/LinqAsync.EFCore.svg)](https://www.nuget.org/packages/LinqAsync.EFCore/) | [![stats](https://img.shields.io/nuget/dt/LinqAsync.EFCore.svg)](https://www.nuget.org/packages/LinqAsync.EFCore/) |

## Usage
Here is an implementation of IAsyncQueryableMethodsProvider for Entity Framework Core.

### Abstraction layer project

The abstraction layer project does not know/implement any async method of the underlying db. It's just focus the business logic in here.
> There is no technical implementation here 

Install the NuGet package from nuget.org

```
PM> Install-Package LinqAsync
```

The following code example does a query for Contract. Use async method FirstOrDefaultAsync to find the first item. 

```csharp
public interface IContactRepository : IQueryable<Contact>
{
}

public class ContactQuery
{
    private readonly IContactRepository _repo;
    
    public ContactQuery(IContactRepository repo)
    {
        _repo = repo;
    } 

    public Task<Contact?> GetContactOrDefaultAsync(Guid id)
    {
        var q = from x in _repo
                where x.Id == id
                select x;
               
        // Here we can use the static extension method for async query without EFCore dependences. 
        return _repo.FirstOrDefaultAsync(q);
    }
}
```

### Repo implementation with EFCore project

This project will install EFCore packages and **LinqAsync.EFCore**

Install the NuGet package from nuget.org

```
PM> Install-Package LinqAsync.EFCore
```

Then we just register the EFCore async query implement to AsyncQueryableExtensions, no more code needed.

```csharp
// register async query EFCore implementation to AsyncQueryableExtensions at startup
var efCoreAsyncQueryable = new EntityFrameworkCoreAsyncQueryableMethodsProvider();
AsyncQueryableExtensions.RegisterAsyncQueryableMethodsProvider(efCoreAsyncQueryable); 
```
All async query will pass-thru the provider (EntityFrameworkCoreAsyncQueryableMethodsProvider in this case) to make async query in Entity Framework Core.

## Final
Leave a comment on GitHub if you have any questions or suggestions.

Turn on the "Star" icon to support if you like it.

## License
This project is licensed under the MIT License
