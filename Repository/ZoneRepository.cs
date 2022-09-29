using DeviceManagement_WebApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Policy;
using System.Threading.Tasks;
using DeviceManagement_WebApp.Models;


namespace DeviceManagement_WebApp.Repository
{
    public class ZoneRepository : GenericRepository<Models.Zone>, IZoneRepository
    {
        public ZoneRepository(ConnectedOfficeContext context) : base(context)
        {
        }

        public Models.Zone GetMostRecentZone()
        {
            throw new NotImplementedException();
        }

        public Models.Zone GetMostRecentService()
        {
            return _context.Zone.OrderByDescending(service => service.DateCreated).FirstOrDefault();
        }
    }

}
