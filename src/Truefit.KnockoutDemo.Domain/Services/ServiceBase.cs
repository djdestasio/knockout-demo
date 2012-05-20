using Ninject;

namespace Truefit.KnockoutDemo.Domain.Services
{
    public abstract class ServiceBase
    {
        [Inject]
        protected ServiceBase(DemoContext context)
        {
            Context = context;
        }

        public DemoContext Context { get; set; }
    }
}