using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Compi.DesignPatterns.Test.Common
{
    public class TestBase
    {
        public TestContext TestContext { get; set; }


      
        protected void WriteDescription(Type type)
        {
            string testName = TestContext.TestName;


            MemberInfo method = type.GetMethod(testName);
            if (method != null)
            {

                Attribute attr = method.GetCustomAttribute(typeof(DescriptionAttribute));
                if (attr != null)
                {

                    DescriptionAttribute dattr = (DescriptionAttribute)attr;

                    TestContext.WriteLine("Test Description: " + dattr.Description);
                }
            }
        }

    }
}
