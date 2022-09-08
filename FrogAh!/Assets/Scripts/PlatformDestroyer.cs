using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformDestroyer : MonoBehaviour
{
    public GameObject PlatformDestructionPoint;

    // Start is called before the first frame update
    void Start()
    {
        PlatformDestructionPoint=GameObject.Find("PlatformDestructionPoint");
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < PlatformDestructionPoint.transform.position.y){
            //Destroy(gameObject);

            gameObject.SetActive(false);
        }
    }
}
