using System;
using System.Collections.Generic;
using System.Text;

using NUnit.Framework;

namespace PayPal.UnitTest
{
    [SetUpFixture]  
    public class SetupTests
    {
        [SetUp]
    	public void RunBeforeAnyTests()
	    {
            log4net.Config.XmlConfigurator.Configure();
	    }

    }
}
