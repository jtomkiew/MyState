using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Diagnostics;

namespace MyStateImplementation
{
    class MyStateTests
    {
        [Test]
        public void TwoDifferentStates()
        {
            var TrueState = MyState.True;
            var FalseState = MyState.False;

            Assert.AreNotEqual(TrueState, FalseState);
        }

        [Test]
        public void TwoSameStates()
        {
            var TrueState = MyState.True;
            var AnotherTrueState = MyState.True;

            Assert.AreEqual(TrueState, AnotherTrueState);
        }

        [Test]
        public void EqualityOperator()
        {
            var TrueState = MyState.True;
            var AnotherTrueState = MyState.True;

            Assert.True(TrueState == AnotherTrueState);
        }

        [Test]
        public void InequalityOperator()
        {
            var TrueState = MyState.True;
            var AnotherTrueState = MyState.True;

            Assert.False(TrueState != AnotherTrueState);
        }

        [Test]
        public void SameyOrNot()
        {
            MyState FirstState = MyState.Null;
            MyState SecondState = MyState.True;

            Assert.AreNotSame(FirstState, SecondState);

            SecondState = MyState.Null;

            Assert.AreSame(FirstState, SecondState);
        }

        [Test]
        public void DoSomeLoops()
        {
            MyState FirstState;
            var sw = new Stopwatch();
            long counter = 0;
            sw.Start();
            while (sw.ElapsedMilliseconds < 50)
            {
                FirstState = MyState.True;
                counter++;
            }
            sw.Stop();
            Console.WriteLine($"Assigned {counter} times in a span of {sw.ElapsedMilliseconds / 1000.0} seconds.");
        }
    }
}
