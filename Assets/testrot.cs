using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testrot : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetUpVector = new Vector3(-0.5f, 0.5f, 0f);
        RotateToUpVector(targetUpVector);
    }
     
    void RotateToUpVector(Vector3 targetUpVector)
    {
        // Norm�r den �nskede up-vektor
        targetUpVector.Normalize();

        // Beregn den n�dvendige rotation for at opn� den �nskede up-vektor
        Quaternion targetRotation = Quaternion.FromToRotation(transform.up, targetUpVector) * transform.rotation;

        // Anvend rotationen
        transform.rotation = targetRotation;
    }
}
