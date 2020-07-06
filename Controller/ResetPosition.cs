using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPosition : MonoBehaviour
{

    [SerializeField, Tooltip("transform")]
    private Transform TargetTransform;
    private Vector3 StartRelativePosition;
    private Vector3 StartRelativeForward;

    void Start()
    {
        StartRelativePosition = TargetTransform.InverseTransformPoint(this.transform.position);
        //StartRelativeForward = TargetTransform.InverseTransformDirection(this.transform.forward);
    }

    void Update()      
    {
        {
            if (Input.GetKeyDown("joystick button 1"))
            {
                Vector3 ResetWorldPosition = TargetTransform.TransformPoint(StartRelativePosition);

                this.transform.position = ResetWorldPosition;

                //Vector3 ResetWorldForward = TargetTransform.TransformDirection(StartRelativeForward);

                //this.transform.forward = ResetWorldForward;
            }
        }
    }
}