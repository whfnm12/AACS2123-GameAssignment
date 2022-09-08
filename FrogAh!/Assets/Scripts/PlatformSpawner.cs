using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
   public GameObject thePlatform;
   public Transform generationPoint;
   public float distanceBetween;

   private float platformWidth;

    public float distanceBetweenMin;
    public float distanceBetweenMax;

    public GameObject[] thePlatforms;
    private int platformSelector;
    private float[] platformWidths;

    private float minWidth;
    public Transform maxWidthPoint;
    private float maxWidth;
    public float maxWidthChange;
    private float widthChange;
  

    void Start () {
        platformWidths= new float[thePlatforms.Length];

        for (int i = 0; i < thePlatforms.Length; i++)
        {
            platformWidths[i] = thePlatforms[i].GetComponent<BoxCollider2D>().size.y;
                
        }

        minWidth=transform.position.x;
        maxWidth=maxWidthPoint.position.x;

    }
    
    //funktion for spawn
   void Update(){
        if (transform.position.y<generationPoint.position.y)
        {

            distanceBetween = Random.Range(distanceBetweenMin,distanceBetweenMax);

            platformSelector = Random.Range(0,thePlatforms.Length);

            widthChange= transform.position.x + Random.Range(maxWidthChange,-maxWidthChange);

            if (widthChange>maxWidth)
            {
                widthChange=maxWidth;
            }else if(widthChange<minWidth){
                widthChange=minWidth;
            }
           

            transform.position = new Vector3(widthChange,transform.position.y + distanceBetween,transform.position.z);

            Instantiate(thePlatforms[platformSelector],transform.position, transform.rotation);
        }
   }
}
