using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment29
{
    public class Animal
    {
        public virtual void MakeSound()
        {
            Debug.Log("Animal sound");
        }

        public virtual void Move()
        {
            Debug.Log("Animal moves.");
        }
    }

    public class Cat : Animal, ICanFight
    {
        public override void MakeSound()
        {
            Debug.Log("Meow!");
        }

        public override void Move()
        {
            Debug.Log("Cat runs quickly.");
        }

        public void Attack()
        {
            Debug.Log("Cat attacks with claws!");
        }
    }

    public class Warrior : ICanFight
    {
        public void Attack()
        {
            Debug.Log("Warrior attacks with a sword!");
        }
    }

    public interface ICanFight
    {
        void Attack();
    }
}

