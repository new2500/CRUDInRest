# CRUDInRest
a RESTful web service that performs CRUD operation for a Vehicle entity
A Vehicle is a simple object defined as follows:
```
public class Vehicle
{
   public int Id {get; set;}
   public int Year {get; set;}
   public string Make {get; set;}
   public string Model {get; set;}
}
```

Restful operations are following:
GET vehicles
GET vhicles/{id}
POST ehciles
PUT vehicles
DELETE vehciles/{id}
