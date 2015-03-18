using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Security.Claims;
using TodoSPA.DAL;

namespace TodoSPA.Controllers
{
    public class ResourcesControllerController : ApiController
    {
        private TodoListServiceContext db = new TodoListServiceContext();

        // GET: api/Resources
        public IEnumerable<Resource> Get()
        {
            IEnumerable<Resource> resources = db.Resources;
            return resources;
        }

        // GET: api/Resources/5
        public Resource Get(int id)
        {
            Resource resource = db.Resources.First(a=> a.ID == id);             
            return resource;
        }

        // POST: api/Resources
        public void Post(Resource resource)
        {
            db.Resources.Add(resource);
            db.SaveChanges();            
        }

        public void Put(Resource resource)
        {
            Resource xresource = db.Resources.First(a=> a.ID == resource.ID);
            if (resource != null)
            {
                xresource.Remaining = resource.Remaining;
                xresource.Status = resource.Status;
                xresource.Name = resource.Name;
                xresource.GroupID = resource.GroupID;
                db.SaveChanges();
            }
        }

        // DELETE: api/Resource/5
        public void Delete(int id)
        {
            Resource resource = db.Resources.First(a => a.ID == id);
            if (resource != null)
            {
                db.Resources.Remove(resource);
                db.SaveChanges();
            }
        }        
    }
}
