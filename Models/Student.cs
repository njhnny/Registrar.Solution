using System.Collections.Generic;

namespace Registrar.Models
{
  public class Student
  {
    public Student()
    {
      this.JoinEntities = new HashSet<CourseStudent>();
    }

    public int StudentId { get; set; }
    public string Description { get; set; }

    public virtual ICollection<CourseStudent> JoinEntities { get;}
  }
}