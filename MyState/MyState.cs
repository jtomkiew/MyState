using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStateImplementation
{
    public class MyState : IEquatable<MyState>
    {
        private EState state;

        public static MyState False = new FalseState();
        public static MyState True = new TrueState();
        public static MyState Null = new NullState();
        public static MyState Undefined = new UndefinedState();

        //public MyState() {
        //    Console.WriteLine("Constructed!");
        //}

        public bool Equals(MyState other)
        {
            if (other == null)
                return false;

            if (this.state == other.state)
                return true;
            else
                return false;
        }

        public override bool Equals(Object obj)
        {
            if (obj == null)
                return false;

            MyState myStateObj = obj as MyState;
            if (myStateObj == null)
                return false;
            else
                return Equals(myStateObj);
        }

        public override int GetHashCode()
        {
            return this.state.GetHashCode();
        }

        public static bool operator == (MyState state1, MyState state2)
        {
            if (((object)state1) == null || ((object)state2) == null)
                return Object.Equals(state1, state2);

            return state1.Equals(state2);
        }

        public static bool operator != (MyState state1, MyState state2)
        {
            if (((object)state1) == null || ((object)state2) == null)
                return !Object.Equals(state1, state2);

            return !(state1.Equals(state2));
        }

        protected enum EState
        {
            False,
            True,
            Null,
            Undefined
        }

        class FalseState : MyState
        {
            public FalseState()
            {
                state = EState.False;
            }
        }

        class TrueState : MyState
        {
            public TrueState()
            {
                state = EState.True;
            }
        }

        class NullState : MyState
        {
            public NullState()
            {
                state = EState.Null;
            }
        }

        class UndefinedState : MyState
        {
            public UndefinedState()
            {
                state = EState.Undefined;
            }
        }
    }
}
