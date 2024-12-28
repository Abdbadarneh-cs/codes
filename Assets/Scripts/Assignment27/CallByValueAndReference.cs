using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment27
{
    public class CallByValueAndReference : MonoBehaviour
    {
        void Start()
        {
            int a = 5;
            int b = 10;
            int c;

            Debug.Log($"Initial value of a: {a}");
            Debug.Log($"Initial value of b: {b}");
            ModifyByValue(a);
            Debug.Log($"Value of a after ModifyByValue call: {a}"); 
            ModifyByReference(ref b);
            Debug.Log($"Value of b after ModifyByReference call: {b}"); 
            AssignUsingOut(out c);
            Debug.Log($"Value of c after AssignUsingOut call: {c}"); 
        }
        void ModifyByValue(int number)
        {
            number += 10; 
            Debug.Log($"Inside ModifyByValue: {number}");
        }
        void ModifyByReference(ref int number)
        {
            number += 10; 
            Debug.Log($"Inside ModifyByReference: {number}");
        }
        void AssignUsingOut(out int number)
        {
            number = 42; 
            Debug.Log($"Inside AssignUsingOut: {number}");
        }
    }
}
