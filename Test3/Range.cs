using System;
using System.Collections.Generic;
using System.Linq;

namespace Test3
{
    public class Range
    {
        private int _start = 0;

        public int Start
        {
            get => _start;
            set => _start = value;
        }

        private int _end = 0;

        public int End
        {
            get => _end;
            set
            {
                if (value < _start + 10)
                {
                    throw new Exception("End should be more start on 10");
                }

                _end = value;
            }
        }

        public Range(int start, int end)
        {
            _start = start;
            _end = end;
        }

        public int getValues()
        {
            var sum = 0;
            
            for (int i = _start; i < _end; i++)
            {
                if ((i % 3 == 0) && (i % 5 != 0))
                {
                    sum += i;
                }
            }

            return sum;
        }
    }
}