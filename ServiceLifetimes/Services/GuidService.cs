using ServiceLifetimes.Interfaces;

namespace ServiceLifetimes.Services
{
    public class GuidService : ITransientService, IScopedService, ISingletonService
    {
        public Guid Id { get; }

        public GuidService()
        {
            Id = Guid.NewGuid();
        }
    }
}
