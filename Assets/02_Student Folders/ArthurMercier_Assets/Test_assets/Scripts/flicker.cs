using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flicker : MonoBehaviour
{

    public float offTime;
    public float onTime;
    public Light spotLight;

    // Start is called before the first frame update
    private void Start()
    {
        StartCoroutine(FlickerRoutine());
    }

    private IEnumerator FlickerRoutine()
    {
        WaitForSeconds waitOffTime = new WaitForSeconds(offTime);
        WaitForSeconds waitOnTime = new WaitForSeconds(onTime);
        while (true)
        {

            yield return waitOffTime;
            spotLight.enabled = false;
            //GetComponent<FieldOfView>().enabled = false;
            GetComponent<FieldOfView>().lightOn = false;
            GetComponent<FieldOfView>().canSeePlayer = false;
           yield return waitOnTime;
            spotLight.enabled = true;
            //GetComponent<FieldOfView>().enabled = true;
            GetComponent<FieldOfView>().lightOn = true;


        }
    }
}