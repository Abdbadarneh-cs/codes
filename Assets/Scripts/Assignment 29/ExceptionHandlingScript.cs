using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment29
{
    public class ExceptionHandlingScript : MonoBehaviour
    {
        void Start()
        {
            int playerScore = 100;
            int divisor = 0;

            try
            {
                Debug.Log("Attempting to calculate score multiplier...");
                int totalScore = playerScore / divisor;
            }
            catch (System.DivideByZeroException)
            {
                Debug.LogError("Error: Division by zero occurred while calculating score multiplier.");
            }
            finally
            {
                Debug.Log("Score calculation complete. Cleaning up resources.");
            }
        }
    }
}