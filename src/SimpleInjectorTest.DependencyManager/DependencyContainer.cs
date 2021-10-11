using SimpleInjector;
using SimpleInjectorTest.Utils;

namespace SimpleInjectorTest.DependencyManager
{
    public static class DependencyContainer
    {
        static Container container;

        public static Container Container { get { return container; } }

        static DependencyContainer()
        {
            container = new SimpleInjector.Container();

            container.Register<IRegexTester, RegexTester>();
        }
    }
}
