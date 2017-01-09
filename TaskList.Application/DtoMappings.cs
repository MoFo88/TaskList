using AutoMapper;
using TaskList.Entities;
using TaskList.Tasks.Dtos;

namespace TaskList
{
    internal class DtoMappings
    {
        internal static void Map(IMapperConfigurationExpression mapper)
        {
            mapper.CreateMap<Task, TaskDto>().ForMember(t => t.AssignedPersonId, opts => opts.MapFrom(d => d.AssignedPerson.Id));
        }
    }
}