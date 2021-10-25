using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerController : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        transform.position = Vector3.zero;

        
    }

    // Update is called once per frame
    void Update()
    {
        ScaleGameObject(new Vector3(0.5f, 0f, 0f), KeyCode.X);
        ScaleGameObject(new Vector3(0f, 0.5f, 0f), KeyCode.Y);
        ScaleGameObject(new Vector3(0f, 0f, 0.5f), KeyCode.Z);
    }   
    public void ScaleGameObject(Vector3 scale, KeyCode kCode)
        
    { if (Input.GetKeyDown(kCode))
        {
            transform.localScale += scale;
        }

    }
}
