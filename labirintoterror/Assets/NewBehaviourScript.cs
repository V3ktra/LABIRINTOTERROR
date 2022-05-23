using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Vector3 cam;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      if(Input.GetKey(KeyCode.W))
    {
        cam.x = 0.1F;
        cam.y = 0.1F;
        cam.z = 0.1F;
        transform.Translate(cam);
    }
    }

}
