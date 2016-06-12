using SimpleCqrs;
using SimpleCqrs.Commanding;
using SimpleCqrs.Unity;

namespace SimpleCQRSDemo
{
    public class SampleRunTime : SimpleCqrsRuntime<UnityServiceLocator>
    {
        private static readonly SampleRunTime _instance = new SampleRunTime();
        public static SampleRunTime Instance
        {
            get
            {
                return _instance;
            }
        }

        public ICommandBus CommandBus
        {
            get
            {
                return Instance.ServiceLocator.Resolve<ICommandBus>();
            }
        }
    }
}