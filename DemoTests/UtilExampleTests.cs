using BLL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xunit;

namespace DemoTests
{
    public class UtilExampleTests
    {

        [Fact]
        public void ExampleLoadingFile_ValidNameShouldWork()
        {
            var actual = UtilExample.ExampleLoadingFile("This is the my file name");
            Assert.True(actual.Length > 0);
        }

        [Fact]
        public void ExampleLoadingFile_InValidNameShouldFail()
        {
            Assert.Throws<ArgumentException>("file",() => UtilExample.ExampleLoadingFile("This"));
        }

    }
}
