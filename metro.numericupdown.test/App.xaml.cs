using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using DryIoc;
using Prism.DryIoc;
using Prism.Ioc;

namespace metro.numericupdown.test
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        public static Rules DefaultRules => Rules.Default.WithConcreteTypeDynamicRegistrations(reuse: Reuse.Transient)
            .With(Made.Of(FactoryMethod.ConstructorWithResolvableArguments))
            .WithFuncAndLazyWithoutRegistration()
            .WithTrackingDisposableTransients()
            //.WithoutFastExpressionCompiler()
            .WithFactorySelector(Rules.SelectLastRegisteredFactory());

        protected override Rules CreateContainerRules()
        {
            return DefaultRules;
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<MainWindow>();
            containerRegistry.Register<ShellView>();
            containerRegistry.Register<ShellViewModel>();
        }

        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }
    }
}
