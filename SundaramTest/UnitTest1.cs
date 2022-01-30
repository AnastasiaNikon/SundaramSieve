using NUnit.Framework;
using SundaramSieve;
using System.Collections.Generic;

namespace SundaramTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            uint n = 1;
            Sundaram sundaram;
            List<uint> primes = new List<uint>();
            uint size = n - 1;
            while (primes.Count != n)
            {
                size++;
                sundaram = new Sundaram(size); // инициализировали экземпл€р класса
                primes = new List<uint>();

                do
                {
                    primes.Add(sundaram.NextPrime);
                } while (primes[primes.Count - 1] != 0); // пока не получили 0 забираем числа

                primes.Remove(0); // удал€ем 0
            }
            List<uint> expectedPrimes = new List<uint>() { 3 };

            Assert.AreEqual(expectedPrimes, primes);
        }

        [Test]
        public void Test2()
        {
            uint n = 10;
            Sundaram sundaram;
            List<uint> primes = new List<uint>();
            uint size = n - 1;
            while (primes.Count != n)
            {
                size++;
                sundaram = new Sundaram(size); // инициализировали экземпл€р класса
                primes = new List<uint>();

                do
                {
                    primes.Add(sundaram.NextPrime);
                } while (primes[primes.Count - 1] != 0); // пока не получили 0 забираем числа

                primes.Remove(0); // удал€ем 0
            }

            List<uint> expectedPrimes = new List<uint>() { 3, 5, 7, 11, 13, 17, 19, 23, 29, 31};

            Assert.AreEqual(expectedPrimes, primes);
        }

        [Test]
        public void Test3()
        {
            uint n = 50;
            Sundaram sundaram;
            List<uint> primes = new List<uint>();
            uint size = n - 1;
            while (primes.Count != n)
            {
                size++;
                sundaram = new Sundaram(size); // инициализировали экземпл€р класса
                primes = new List<uint>();

                do
                {
                    primes.Add(sundaram.NextPrime);
                } while (primes[primes.Count - 1] != 0); // пока не получили 0 забираем числа

                primes.Remove(0); // удал€ем 0
            }

            List<uint> expectedPrimes = new List<uint>() { 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101, 103, 107, 109, 113, 127, 131, 137, 139, 149, 151, 157, 163, 167, 173, 179, 181, 191, 193, 197, 199, 211, 223, 227, 229, 233 };

            Assert.AreEqual(expectedPrimes, primes);
        }
    }
}