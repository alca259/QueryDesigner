using System;
using Xunit;

namespace QueryDesignerCore.UnitTests
{
    public class OrderFilterTest
    {
        [Fact]
        public void ShouldOrderByProperty()
        {
            //Arrange
            var expected = new TestTarget[] {
                new TestTarget { Amount = 2000 },
                new TestTarget { Amount = 1000 }
            };

            var filter = new OrderFilter
            {
                Field = "Amount",
                Order = OrderFilterType.Desc
            };

            var data = new TestTarget[] {
                new TestTarget { Amount = 1000 },
                new TestTarget { Amount = 2000 } };

            //Act
            var actual = data.OrderBy(filter);

            //Assert
            Assert.Equal(expected.ToJson(), actual.ToJson());
        }

        [Fact]
        public void ShouldThrowExceptionWhenPropertyNotFound()
        {
            //Arrange
            var filter = new OrderFilter
            {
                Field = "NoSuchProperty",
                Order = OrderFilterType.Desc,
                Setting = new OrderFilterSetting {
                    SupressPropertyNotFoundException = false
                }
            };

            var data = new TestTarget[] {
                new TestTarget { Amount = 1000 },
                new TestTarget { Amount = 2000 } };

            //Act
            Assert.Throws<InvalidOperationException>(() => data.OrderBy(filter));
        }

        [Fact]
        public void ShouldNotThrowExceptionWhenPropertyNotFound()
        {
            //Arrange
            var expected = new TestTarget[] {
                new TestTarget { Amount = 1000 },
                new TestTarget { Amount = 2000 }
            };

            var filter = new OrderFilter
            {
                Field = "NoSuchProperty",
                Order = OrderFilterType.Desc,
                Setting = new OrderFilterSetting
                {
                    SupressPropertyNotFoundException = true
                }
            };

            var data = new TestTarget[] {
                new TestTarget { Amount = 1000 },
                new TestTarget { Amount = 2000 } };

            //Act
            var actual = data.OrderBy(filter);

            //Assert
            Assert.Equal(expected.ToJson(), actual.ToJson());
        }
    }
}
