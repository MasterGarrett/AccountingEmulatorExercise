using ChargeServices.Repositories;
using StructureMap;

namespace ChargeServices
{
    public class AppConfigurator
    {
        public void Initialize()
        {
            ObjectFactory.Configure(x =>
                                        {
                                             x.For<IServiceChargeRepository>().Singleton();
 
                                             x.Scan(scan =>
                                                        {
                                                            scan.AssemblyContainingType<IServiceChargeSearch>();
                                                            scan.WithDefaultConventions();
                                                        });
                                         });
        }
    }
}
