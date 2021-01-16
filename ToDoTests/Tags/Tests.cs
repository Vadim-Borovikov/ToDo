using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ToDoTests.Tags
{
    [TestClass]
    public class ATests
    {
        [TestMethod]
        public void Test()
        {
            var numbers = new List<int> { 1 };
            Print(numbers);
            numbers.Add(2);
            Print(numbers);
        }

        private static string GetString(IEnumerable<int> numbers) => $"('{string.Join("', '", numbers)}')";
        private static void Print(IEnumerable<int> numbers) => Console.WriteLine(GetString(numbers));
    }
}