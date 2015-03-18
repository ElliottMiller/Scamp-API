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
    public class GroupsControllerController : ApiController
    {
        private TodoListServiceContext db = new TodoListServiceContext();

        // GET: api/Groups
        public IEnumerable<Group> Get()
        {
            IEnumerable<Group> groups = db.Groups;
            return groups;
        }

        // GET: api/Groups/5
        public Group Get(int id)
        {
            Group group = db.Groups.First(a=> a.ID == id);             
            return group;
        }

        // POST: api/Groups
        public void Post(Group group)
        {
            db.Groups.Add(group);
            db.SaveChanges();            
        }

        public void Put(Group group)
        {
            Group xgroup = db.Groups.First(a=> a.ID == group.ID);
            if (group != null)
            {
                xgroup.Name = group.Name;
                db.SaveChanges();
            }
        }

        // DELETE: api/Group/5
        public void Delete(int id)
        {
            Group group = db.Groups.First(a => a.ID == id);
            if (group != null)
            {
                db.Groups.Remove(group);
                db.SaveChanges();
            }
        }        
    }
}
