using CSharpExercises.Classes.Chapter_11;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CSharpExercises.Tests.Chapter_11
{
    public class SubstancesTests
    {
        [Fact]
        public void CanCreateLiquidInstance()
        {
            IMatter matter = new Liquid("Water", 1);

            Assert.NotNull(matter);
            Assert.Equal("Water", matter.Name);
            Assert.Equal(1, matter.Mass);
            Assert.Equal(States.Liquid, matter.State);
        }

        [Fact]
        public void CanCreatePlasmaInstance()
        {
            IMatter matter = new Plasma("Lightning", 1);

            Assert.NotNull(matter);
            Assert.Equal("Lightning", matter.Name);
            Assert.Equal(1, matter.Mass);
            Assert.Equal(States.Plasma, matter.State);
        }

        [Fact]
        public void CanCreateSolidInstance()
        {
            IMatter matter = new Solid("Ice", 0.9);

            Assert.NotNull(matter);
            Assert.Equal("Ice", matter.Name);
            Assert.Equal(0.9, matter.Mass);
            Assert.Equal(States.Solid, matter.State);
        }

        [Fact]
        public void CanCreateGasInstance()
        {
            IMatter matter = new Gas("Air", 0.1);

            Assert.NotNull(matter);
            Assert.Equal("Air", matter.Name);
            Assert.Equal(0.1, matter.Mass);
            Assert.Equal(States.Gas, matter.State);
        }

        [Fact]
        public void CanCreateSubstancesInstance()
        {
            var substances = new Substances();

            Assert.NotNull(substances);
            Assert.NotEmpty(substances.SateNames);
            Assert.Equal(States.Liquid, substances.GetStateValue("Liquid"));
            Assert.NotEmpty(substances.Get());
            Assert.NotEmpty(substances.Get(m => m.State.Equals(States.Liquid)));
        }
    }
}
