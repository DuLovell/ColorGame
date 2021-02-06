using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorSphere : MonoBehaviour
{
    #region Fields
    HingeJoint2D joint;
    JointMotor2D jointMotor;
    bool isClockForward = true;
    #endregion

    #region Properties

    #endregion

    #region Methods
    void Awake()
    {
        joint = GetComponent<HingeJoint2D>();
        jointMotor = joint.motor;
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isClockForward && (joint.jointAngle >= joint.limits.max))
        {
            print(jointMotor.motorSpeed);
            isClockForward = false;
            jointMotor.motorSpeed = -jointMotor.motorSpeed;
            joint.motor = jointMotor;
        }
        else if (!isClockForward && (joint.jointAngle <= joint.limits.min))
        {
            isClockForward = true;
            jointMotor.motorSpeed = -jointMotor.motorSpeed;
            joint.motor = jointMotor;
        }
    }
    #endregion

}
