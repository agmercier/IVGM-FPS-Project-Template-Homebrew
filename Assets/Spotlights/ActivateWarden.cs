using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateWarden : MonoBehaviour

{

    public GameObject warden;
    public Transform spawnPos;
    public float minDist;
    //public float spawnTime;

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
        if (GetComponent<FieldOfView>().canSeePlayer)
        {
            float dist = Vector3.Distance(warden.transform.position, gameObject.transform.position);
            if (dist > minDist)
            {
            //    StartCoroutine(WaiteCoroutine());
                if (!wardenSpawned)
                {
                    warden.SetActive(true);
                    wardenSpawned = true;
                }

                warden.transform.position = spawnPos.position;
            }



        }

    }
    //IEnumerator WaiteCoroutine()
    //{
    //    yield return new WaitForSeconds(spawnTime);
    //}
}
