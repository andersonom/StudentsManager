using MongoDB.Bson; 

namespace StudentsManager.Domain.Models
{
    public class Course
    {
        public ObjectId Id { get; set; }         
        public string Name { get; set; }        
    }
}