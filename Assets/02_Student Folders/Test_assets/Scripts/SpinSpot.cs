using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinSpot : MonoBehaviour
{
    public int untilFlipLeft;
    public float untilFlipRight;
    public float spinSpeed;

    private int iterLeft;
    private int iterRight;
    private Rigidbody m_Rigidbody;
    Vector3 m_EulerAngleVelocity;

    void Start()
    {
        iterLeft = 0;
        iterRight = 0;
        m_Rigidbody = GetComponent<Rigidbody>();  
        m_EulerAngleVelocity = new Vector3(0, spinSpeed, 0);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (iterLeft < untilFlipLeft)
        {
            Quaternion deltaRotation = Quaternion.Euler(m_EulerAngleVelocity * Time.fixedDeltaTime);
            m_Rigidbody.MoveRotation(m_Rigidbody.rotation * deltaRotation);
            iterLeft++;
        }
        else if (iterRight < untilFlipRight)
        {
            Quaternion deltaRotation = Quaternion.Euler(m_EulerAngleVelocity * Time.fixedDeltaTime * -1);
            m_Rigidbody.MoveRotation(m_Rigidbody.rotation * deltaRotation);
            iterRight++;
        }
        else
        {
            iterRight = 0;
            iterLeft = 0;
        }

     
       
    }
}
