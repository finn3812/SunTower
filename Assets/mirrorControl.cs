using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mirrorControl : MonoBehaviour
{
    public LineRenderer line;
    GameObject sun;
    GameObject sunTarget;
    public GameObject mirror;
    Vector3 SunToMirror=new Vector3(0,0,0);
    Vector3 MirrorToTarget=new Vector3(0,0,0);
    Vector3 middelVektor=new Vector3(0,0,0);

    // Start is called before the first frame update
    void Start()
    {       
        sun = GameObject.Find("Sun");
        sunTarget = GameObject.Find("SunTarget");
    }


    // Update is called once per frame
    void Update()
    {
        SunToMirror = mirror.transform.position - sun.transform.position;
        MirrorToTarget = sunTarget.transform.position - mirror.transform.position;
        middelVektor = (-Vector3.Normalize(SunToMirror) + Vector3.Normalize(MirrorToTarget)) / 2;
        
        RotateToUpVector(middelVektor);
        setSunLine();
    }


   
    void RotateToUpVector(Vector3 MirrorNormalVector)
    {
        MirrorNormalVector.Normalize();
        Quaternion targetRotation = Quaternion.FromToRotation(mirror.transform.up, MirrorNormalVector) * mirror.transform.rotation;
        mirror.transform.rotation = targetRotation;
    }

    void setSunLine()
    {
        line.SetPosition(0, transform.InverseTransformPoint(sun.transform.position));
        line.SetPosition(1, transform.InverseTransformPoint(mirror.transform.position));
        line.SetPosition(2, transform.InverseTransformPoint(sunTarget.transform.position));

    }
}
