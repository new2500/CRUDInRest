using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CRUDInRest
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceVehicle" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceVehicle.svc or ServiceVehicle.svc.cs at the Solution Explorer and start debugging.
    public class ServiceVehicle : IServiceVehicle
    {

        public List<Vehicle> getall()
        {
            using (mydemoEntities mde = new mydemoEntities())
            {
                return mde.VehicleEntities.Select(ve => new Vehicle {
                    ID = ve.ID,
                    Year = ve.Year.Value,
                    Make= ve.Make,
                    Model= ve.Model
                }).ToList();
            };
        }

        public Vehicle get(string id)
        {
            
            using (mydemoEntities mde = new mydemoEntities())
            {
                int nid = Convert.ToInt32(id);
                return mde.VehicleEntities.Where( ve=> ve.ID==nid).Select(ve => new Vehicle
                {
                    ID = ve.ID,
                    Year = ve.Year.Value,
                    Make = ve.Make,
                    Model = ve.Model
                }).First();
            };
        }

        public bool create(Vehicle vehicle)
        {
            using (mydemoEntities mde = new mydemoEntities())
            {
                try
                {
                    VehicleEntity ve = new VehicleEntity();
                    ve.Year = vehicle.Year;
                    ve.Make = vehicle.Make;
                    ve.Model = vehicle.Model;
                    mde.VehicleEntities.Add(ve);
                    mde.SaveChanges();
                    return true;
                }
                catch (Exception)
                {

                    return false;
                }
                
                
            };
        }

        public bool delete(Vehicle vehicle)
        {
            using (mydemoEntities mde = new mydemoEntities())
            {
                try
                {
                    int id = Convert.ToInt32(vehicle.ID);
                    VehicleEntity ve = mde.VehicleEntities.Single(v => v.ID == id);
                    mde.VehicleEntities.Remove(ve);
                    mde.SaveChanges();
                    return true;
                }
                catch (Exception)
                {

                    return false;
                }
            }
        }

        public bool edit(Vehicle vehicle)
        {
            using (mydemoEntities mde = new mydemoEntities())
            {
                try
                {
                    int id = Convert.ToInt32(vehicle.ID);
                    VehicleEntity ve = mde.VehicleEntities.Single(v=>v.ID == id);
                    ve.Year = vehicle.Year;
                    ve.Make = vehicle.Make;
                    ve.Model = vehicle.Model;
                    mde.SaveChanges();
                    return true;
                }
                catch (Exception)
                {

                    return false;
                }


            };
        }




    }
}

