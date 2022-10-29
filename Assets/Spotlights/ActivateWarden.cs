using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateWarden : MonoBehaviour

{

    public GameObject warden;
    public Transform spawnPos;
    public float minDist;
    private float dist;
    //public float spawnTime;

    // Start is called before the first frame update
    void Start()
    {
        warden.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<FieldOfView>().canSeePlayer)
        {
            dist = Vector3.Distance(warden.transform.position, spawnPos.transform.position);
            if (dist > minDist)
            {
            //    StartCoroutine(WaiteCoroutine());
                if (!warden.activeInHierarchy)
                {
                    warden.SetActive(true);
                }
                warden.GetComponent<UnityEngine.AI.NavMeshAgent>().Warp (spawnPos.position);
            }
        }

    }
    //IEnumerator WaiteCoroutine()
    //{
    //    yield return new WaitForSeconds(spawnTime);
    //}
}
