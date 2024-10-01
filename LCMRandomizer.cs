using UnityEngine;

namespace TA
{
    public class LCMRandomizer
    {
        private int a; // multiplier
        private int c; // increment
        private int m; // modulus
        private int seed; // initial seed value
        private int current; // current value in the sequence

        public LCMRandomizer(int a, int c, int m, int seed)
        {
            this.a = a;
            this.c = c;
            this.m = m;
            this.seed = seed;
            this.current = seed;
        }

        public int Next()
        {
            current = (a * current + c) % m;
            return current;
        }
    }
}