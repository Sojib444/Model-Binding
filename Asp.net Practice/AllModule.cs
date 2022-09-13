
using Asp.net_Practice.Areas.Kudvenkat.Models.Empolyee;
using Asp.net_Practice.Areas.Kudvenkat.Models.Empolyee.RepositoryClass;
using Autofac;

namespace Asp.net_Practice
{
    public class AllModule:Module 
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<SqlServerRepository>().As<IEmpolyee>();
            
            base.Load(builder);
        }
    }
}
