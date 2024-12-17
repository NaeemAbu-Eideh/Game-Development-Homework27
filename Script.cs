using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Assignment27 {

    public class Script : MonoBehaviour
    {
        public void ChangeNumberBuValue(int number) {
           number *= number;
        }

        public void ChangeNumberByRefrence(ref int number) {
            number *= number ;
        }

        public void ChangeNumberByOut(out int number) {
            number = 42;
        }

        void Start()
        {
            int num1 = 4, num2 = 4, num3 = 0;


            Debug.Log("---------By Value-------------");
            Debug.Log($"the first number before change is {num1}");
            ChangeNumberBuValue(num1);
            Debug.Log($"the first number before change is {num1}");

            Debug.Log("---------By Reference-------------");
            Debug.Log($"the second number before change is {num2}");
            ChangeNumberByRefrence(ref num2);
            Debug.Log($"the second number before change is {num2}");

            Debug.Log("---------By Out-------------");
            Debug.Log($"the third number before change is {num3}");
            ChangeNumberByOut(out num3);
            Debug.Log($"the third number before change is {num3}");

        }
        void Update()
        {

        }
    }

}


