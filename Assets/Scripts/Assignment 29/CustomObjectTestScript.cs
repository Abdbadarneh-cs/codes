using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment29
{
    public class CustomObjectTestScript : MonoBehaviour
    {
        void Start()
        {
            CustomObject obj = new CustomObject(1, "Example");
            print(obj);
        }
    }
}
