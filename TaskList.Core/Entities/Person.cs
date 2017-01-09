using Abp.Domain.Entities;

namespace TaskList.Entities
{
    public class Person : Entity
    {
        public virtual string Name { get; set; }
    }
}
