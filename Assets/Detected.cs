using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detected : MonoBehaviour
{
    [Tooltip("Visible transform that will be destroyed once the objective is completed")]
    //public Transform destroyRoot;


    void Awake()
    {
    }

    void OnTriggerEnter(Collider other)
    {

        var player = other.GetComponent<PlayerCharacterController>();
        // test if the other collider contains a PlayerCharacterController, then complete
        if (player != null)
        {
            print("Detected");

            // destroy the transform, will remove the compass marker if it has one
            //Destroy(destroyRoot.gameObject);
        }
    }
}
