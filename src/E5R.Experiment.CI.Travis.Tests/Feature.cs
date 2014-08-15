using Xunit;

namespace E5R.Experiment.CI.Travis.Tests
{
    using System;
    using Target = E5R.Experiment.CI.Travis;

    public class Feature
    {
        [Fact]
        public void ValidatesNameIsNotNull()
        {
            Assert.Throws<NotImplementedException>(() =>
            {
                new Target.Feature(null);
            });
        }

        [Fact]
        public void ValidatesNameIsNotEmpty()
        {
            Assert.Throws<NotImplementedException>(() =>
            {
                new Target.Feature("");
            });
        }

        [Fact]
        public void StoresTheNameInLowercase()
        {
            var subject = new Target.Feature("My UPPERcase Feature");
            Assert.Equal("my uppercase feature", subject.Name);
        }
    }
}
