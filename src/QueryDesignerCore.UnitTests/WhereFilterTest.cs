using System;
using System.Linq;
using Xunit;

namespace QueryDesignerCore.UnitTests
{
    internal class TestTarget {
        public string Name { get; set; }
    }

    public class WhereFilterTest
    {
        [Fact]
        public void ShouldFilterByContain()
        {
            //Arrange
            var expected = new TestTarget[] { new TestTarget { Name = "DataOne" } };

            var filter = new WhereFilter
            {
                Field = "Name",
                FilterType = WhereFilterType.Contains,
                Value = "One"
            };

            var data = new TestTarget[] {
                new TestTarget { Name = "DataOne" },
                new TestTarget { Name = "DataTwo" } };
            
            //Act
            var actual = data.Where(filter);

            //Assert
            Assert.Equal(expected.ToJson(), actual.ToJson());
        }

        [Fact]
        public void ShouldFilterByContainCaseInsensitive()
        {
            //Arrange
            var expected = new TestTarget[] { new TestTarget { Name = "DataOne" } };

            var filter = new WhereFilter
            {
                Field = "Name",
                FilterType = WhereFilterType.Contains,
                Value = "one",
                Setting = new WhereFilterSetting {
                    CaseInsensitive = true
                }
            };

            var data = new TestTarget[] {
                new TestTarget { Name = "DataOne" },
                new TestTarget { Name = "DataTwo" } };

            //Act
            var actual = data.Where(filter);

            //Assert
            Assert.Equal(expected.ToJson(), actual.ToJson());
        }
    }
}
