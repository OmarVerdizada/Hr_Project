using HrProject.Core.Interfaces;

namespace HrProject.Core.Entitiesl
{
    public class Employee:IEntity<Guid>
    {
        public Guid Id { get;}
        public string Name { get; set; } = null!;
        public string? LastName { get; set; }
        public int? DepartmentId { get; set; }
        public int? PositionID { get; set; }
        public Employee(string name,int departmentid,int positionid,string? lastname)
        {
            Name = name;
            LastName = lastname;
            DepartmentId = departmentid;
            PositionID = positionid;
            Id = new Guid ();
        }
    }
}
