using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
namespace Assignment29
{
    public class BasicsScript : MonoBehaviour
    {
        void Start()
        {
           
            var number = 5;
            var message = "This is a test string."; 
            var isUnityAwesome = true; 
            string evenOdd = (number % 2 == 0) ? "even" : "odd";

            Debug.Log($"The number {number} is {evenOdd}.");
            Debug.Log($"Current Date: {DateTime.Now.ToShortDateString()}");
            Debug.Log($"Current Time: {DateTime.Now.ToLongTimeString()}");
            Debug.Log($"Current Day: {DateTime.Now.DayOfWeek}");
        }
    }
}
