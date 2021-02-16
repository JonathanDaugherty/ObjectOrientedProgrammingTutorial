using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgrammingTutorial {
    
    class Rect : Quad /* how to do inheritance*/{
        
        public int Area() {
            return side1 * side2;
        }
        
        public Rect() : base() { }

        public Rect(int s1, int s2) : base(s1, s2, s1, s2) {

        }
        
      
    }
}
