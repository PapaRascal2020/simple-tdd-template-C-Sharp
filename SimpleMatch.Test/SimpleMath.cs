using System;
using NUnit.Framework;
using SimpleMath;

namespace SimpleMath.Test
{
    public class SimpleMathTest
    {
        [Test]
        public void we_can_add_two_numbers()
        {
            Assert.AreEqual(17, SimpleMath.Add(5, 12));
        }

        [Test]
        public void we_can_calculate_the_number_to_the_power_of_another_numbers()
        {
            Assert.AreEqual(244140625, SimpleMath.Power(5, 12));
        }

        [Test]
        public void we_can_subtract_two_numbers()
        {
            Assert.AreEqual(-7, SimpleMath.Subtract(5, 12));
        }

        [Test]
        public void we_can_multiply_two_numbers()
        {
            Assert.AreEqual(60, SimpleMath.Multiply(5, 12));
        }

        [Test]
        public void we_can_divide_two_numbers()
        {
            Assert.AreEqual(0.4166666666666667, SimpleMath.Divide(5, 12));
        }
    }
}
