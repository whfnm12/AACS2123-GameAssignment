using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boundaries : MonoBehaviour
{
    float xWidthP;
    float yHeightP;

    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        xWidthP=(Screen.width-34)/100;
        yHeightP=(Screen.height-54)/100;

        transform.position=new Vector3(Mathf.Clamp(transform.position.x,-xWidthP+3,xWidthP),Mathf.Clamp(transform.position.y,-yHeightP-10000,yHeightP+10000),0);
    }
}
