using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;
using AutoMapper;
using TaskList.Entities;
using TaskList.Tasks.Dtos;

namespace TaskList
{
    [DependsOn(typeof(TaskListCoreModule), typeof(AbpAutoMapperModule))]
    public class TaskListApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Modules.AbpAutoMapper().Configurators.Add(DtoMappings.Map);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
