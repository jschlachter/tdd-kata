using System;
using Xunit;

namespace StringCalculator.UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Given_an_empty_string_should_return_zero()
        {
            var calculator = new StringCalculator();
            var expected = 0;

            Assert.Equal(expected, calculator.Add(string.Empty));
        }

        [Fact]
        public void Given_a_single_number_should_return_number()
        {
            var calculator = new StringCalculator();
            var expected = 1;

            Assert.Equal(expected, calculator.Add(string.Empty));
        }

        [Fact]
        public void Give_two_numbers_should_return_the_sum_of_both_numbers()
        {
            // TODO: Implement me ...
        }

        [Fact]
        public void Given_multiple_numbers_should_return_the_sum_of_all_numbers()
        {
            // TODO: Implement me ...
        }

        [Fact]
        public void Given_new_line_as_delimeter_should_return_the_sum_of_all_numbers ()
        {
            // TODO: Implement me ..
        }

        [Fact]
        public void Given_negative_number_should_throw_exception ()
        {
            // TODO: Implement me ..
        }
    }
}
