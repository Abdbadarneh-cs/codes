using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacingGame : MonoBehaviour
{
  public RaceState raceState;
    void SimulateRace()
    {
        switch (raceState)
        {
            case RaceState.Start:
                Debug.Log("The race is about begin. get ready!");
                break;

            case RaceState.Accelerate:
                Debug.Log(" press the gas pedal. car speeds up!");
                break;

            case RaceState.Turn:
                Debug.Log("You approach a sharp turn. Be careful not to crash!");
                break;

            case RaceState.Crash:
                Debug.Log("You hit a barrier. The race is over.");
                break;

            case RaceState.Finish:
                Debug.Log("You crossed the finish line. Well done!");
                break;

            default:
                Debug.Log("This state is not defined. Something is wrong.");
                break;
        }
    }
    void Update()
    {
        SimulateRace();
    }
}
