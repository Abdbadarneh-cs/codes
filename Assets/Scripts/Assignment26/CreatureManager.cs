using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment26
{
    public class CreatureManager : MonoBehaviour
    {
        void Start()
        {
            Creature kangaroo = new Kangaroo();
            Creature duck = new Duck();
            List<Creature> creatures = new List<Creature> { kangaroo, duck };
            List<IRunnable> runners = new List<IRunnable>();
            List<IJumpable> jumpers = new List<IJumpable>();
            List<ISwimmable> swimmers = new List<ISwimmable>();
           
            if (kangaroo is IRunnable) runners.Add((IRunnable)kangaroo);
            if (kangaroo is IJumpable) jumpers.Add((IJumpable)kangaroo);
            if (duck is IRunnable) runners.Add((IRunnable)duck);
            if (duck is ISwimmable) swimmers.Add((ISwimmable)duck);

            Debug.Log("Creature Sounds:");
            foreach (Creature creature in creatures)
            {
                creature.Speak();
            }

          
            Debug.Log("\nRunners:");
            foreach (IRunnable runner in runners)
            {
                runner.Run();
            }

            Debug.Log("\nJumpers:");
            foreach (IJumpable jumper in jumpers)
            {
                jumper.Jump();
            }

            Debug.Log("\nSwimmers:");
            foreach (ISwimmable swimmer in swimmers)
            {
                swimmer.Swim();
            }
        }
    }
}
