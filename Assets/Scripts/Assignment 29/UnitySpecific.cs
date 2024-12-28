using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Assignment29{
public class UnitySpecific : MonoBehaviour
{
        void OnEnable()
        {
            Debug.Log("GameObject Enabled");
        }

        void OnDisable()
        {
            Debug.Log("GameObject Disabled");
        }

        void Start()
        {
            Debug.Log("Game started!");
            GameObject target = GameObject.Find("TargetObject");
            if (target != null) Debug.Log($"Found object by name: {target.name}");

            GameObject joker = GameObject.FindGameObjectWithTag("Joker");
            if (joker != null) Debug.Log($"Found object by tag: {joker.name}");

            Light light = GameObject.FindObjectOfType<Light>();
            if (light != null) Debug.Log($"Found object of type Light: {light.name}");
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                GameObject target = GameObject.Find("TargetObject");
                if (target != null)
                {
                    target.SetActive(false);
                    Debug.Log("TargetObject deactivated!");
                }
            }
        }
}
}
