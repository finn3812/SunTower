using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceMirrors : MonoBehaviour
{
    public GameObject mirrorTemplate;
    public float HeliostatDistance = 2;
    public int NofHeliostatX=10;
    public int NofHeliostatZ = 10;
    // Start is called before the first frame update
    void Start()
    {
        placeMirrors();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void placeMirrors()
    {
        if(mirrorTemplate!=null)
        {
            for (int m=0;m < NofHeliostatZ; m++)
            {
                for (int n = 0; n < NofHeliostatX; n++)
                {
                    Vector3 postion = new Vector3(n * HeliostatDistance - (NofHeliostatX * HeliostatDistance) / 2, 0, m * HeliostatDistance - (NofHeliostatZ * HeliostatDistance) / 2);
                    Quaternion q = Quaternion.identity;
                    GameObject obj = Instantiate(mirrorTemplate, postion, q);
                }
            }
            
        }
    }
}
