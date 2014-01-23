using System;
using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using CRD.UI.Models;
using StructureMap;
using System.Collections.Specialized;
namespace CRD.UI
{
        public class StructureMapControllerFactory : DefaultControllerFactory
        {
            protected override IController
                GetControllerInstance(RequestContext requestContext,
                Type controllerType)
            {
                try
                {
                    if ((requestContext == null) || (controllerType == null))
                        return null;

                    return (Controller)ObjectFactory.GetInstance(controllerType);
                }
                catch (StructureMapException)
                {
                    System.Diagnostics.Debug.WriteLine(ObjectFactory.WhatDoIHave());
                    throw new Exception(ObjectFactory.WhatDoIHave());
                }
            }
        }

        public static class Bootstrapper
        {
            public static void Run()
            {
                ControllerBuilder.Current
                    .SetControllerFactory(new StructureMapControllerFactory());

                ObjectFactory.Initialize(x => x.For<ILoanRepository>().Use<Loan>());
            }
        }
}