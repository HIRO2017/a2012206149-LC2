[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(a12206149.MVC.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(a12206149.MVC.App_Start.NinjectWebCommon), "Stop")]

namespace a12206149.MVC.App_Start
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;
    using a12206149_ENT.IRepositories;
    using a12206149_PER.Repositories;
    using System.Data.Entity;
    using a12206149_PER;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind<IUnityOfWork>().To<UnityOfWork>();
            kernel.Bind<a12206149DbContext>().To<a12206149DbContext>();



            kernel.Bind<IAdministrativoRepository>().To<AdministradorRepository>();
            kernel.Bind<IBusRepository>().To<BusRepository>();
            kernel.Bind<IClienteRepository>().To<ClienteRepository>();
            kernel.Bind<IEmpleadoRepository>().To<EmpleadoRepository>();
            kernel.Bind<IEncomiendaRepository>().To<EncomiendaRepository>();
            kernel.Bind<IServicioRepository>().To<ServicioRepository>();
            kernel.Bind<ITransporteRepository>().To<TransporteRepository>();
            kernel.Bind<ITripulacionRepository>().To<TripulacionRepository>();
            kernel.Bind<IVentaRepository>().To<VentaRepository>();
        }        
    }
}
