using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateWarden : MonoBehaviour

{

    public GameObject warden;

    private bool wardenSpawned;
    // Start is called before the first frame update
    void Start()
    {
        warden.SetActive(false);
        wardenSpawned = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(GetComponent<FieldOfView>().canSeePlayer && !wardenSpawned)
        {
            warden.SetActive(true);
            wardenSpawned = true;
        }

    }
}
