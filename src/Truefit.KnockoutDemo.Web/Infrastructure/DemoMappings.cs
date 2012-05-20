using AutoMapper;

namespace Truefit.KnockoutDemo.Web.Infrastructure
{
    public static class DemoMappings
    {
        public static void Initialize()
        {
            PeopleMapping.CreateMaps();
            Mapper.AssertConfigurationIsValid();
        }
    }
}