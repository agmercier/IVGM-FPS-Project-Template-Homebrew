using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class StartCanvase : MonoBehaviour
{
    public GameObject canvas;
    public GameObject friend;
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        canvas.SetActive(false);
        friend.SetActive(true);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Player)
        {
            canvas.SetActive(true);
            friend.SetActive(false);
        }
    }
}
