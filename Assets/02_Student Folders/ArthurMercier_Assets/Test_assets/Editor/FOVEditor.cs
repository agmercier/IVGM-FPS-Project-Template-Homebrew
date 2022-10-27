using UnityEditor;
using UnityEngine;
[CustomEditor(typeof(FieldOfView))]
public class FOVEditor : Editor
{
    private void OnSceneGUI()
    {
        FieldOfView fov = (FieldOfView)target;
        Handles.color = Color.white;

        Vector3 vecUp = (fov.transform.rotation * Vector3.up).normalized;
        Vector3 VecForward = (fov.transform.rotation * Vector3.forward).normalized;

        Handles.DrawWireArc(fov.transform.position, vecUp, VecForward, 360, fov.radius);

      
        Vector3 viewAngle1 = (fov.transform.rotation * DirectionFromAngle(fov.transform.eulerAngles.y, -fov.angle / 2)).normalized; 
        Vector3 viewAngle2 = (fov.transform.rotation * DirectionFromAngle(fov.transform.eulerAngles.y, fov.angle / 2)).normalized;
        //Vector3 viewAngle1 = DirectionFromAngle(fov.transform.eulerAngles.y, -fov.angle / 2);
        //Vector3 viewAngle2 = DirectionFromAngle(fov.transform.eulerAngles.y, fov.angle / 2);

        Handles.color = Color.yellow;
        Handles.DrawLine(fov.transform.position, fov.transform.position + viewAngle1 * fov.radius );
        Handles.DrawLine(fov.transform.position, fov.transform.position + viewAngle2 * fov.radius );

        if (fov.canSeePlayer)
        {
            Handles.color = Color.green;
            Handles.DrawLine(fov.transform.position, fov.playerRef.transform.position);
        }
    }

    private Vector3 DirectionFromAngle(float eulerY, float angleInDegrees)
    {
        angleInDegrees += eulerY;
        return  new Vector3(Mathf.Sin(angleInDegrees * Mathf.Deg2Rad),  0, Mathf.Cos(angleInDegrees * Mathf.Deg2Rad));
    }
        
}
