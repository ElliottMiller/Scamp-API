
namespace TodoSPA.Controllers
{
    public class Todo 
     { 
         public int ID { get; set; } 
         public string Description { get; set; }
         public string Owner { get; set; } 
     }

    public class Group
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    public class Resource
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public int GroupID { get; set; }
        public decimal Remaining { get; set; }
 
    } 

}