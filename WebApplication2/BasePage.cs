using Autofac;
using System;
using System.Web.UI;
namespace WebApplication2
{
    public abstract class BasePage : Page
    {
        protected ILifetimeScope Scope;

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            Scope = Global.Container.BeginLifetimeScope();
        }

        protected override void OnUnload(EventArgs e)
        {
            Scope?.Dispose();
            base.OnUnload(e);
        }
    }
}