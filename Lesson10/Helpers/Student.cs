using System;

namespace Helpers
{
    public class Student
    {
        public string Name;
        internal string Age;
        protected internal string School;

        //public byte IQ { get; set; }

        private int _iq;

        //public void SetIQ(int iq)
        //{
        //    if (iq <=200)
        //    {
        //        _iq = iq;
        //    }
        //    else
        //    {
        //        throw new Exception("IQ cannot");
        //    }
        //}
        //public int GetIq()
        //{
        //    return _iq;
        //}
        public int IQ { 
            get 
            {
                return _iq;
            }
            set 
            {
                if (value<=200)
                {
                    _iq = value;
                }
                else
                {
                    throw new Exception("Iq Cannot");
                }
            }
        }
    }
}
