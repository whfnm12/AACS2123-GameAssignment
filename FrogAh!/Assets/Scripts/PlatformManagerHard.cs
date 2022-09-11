using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformManagerHard : MonoBehaviour
{
    public static PlatformManagerHard Instance= null;

    [SerializeField]GameObject platformPrefab;

    // Start is called before the first frame update
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance!=this)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Start()
    {
        
    }

    IEnumerator SpawnPlatform(Vector2 spawnPosition){
        yield return new WaitForSeconds(1);
        Instantiate(platformPrefab,spawnPosition,platformPrefab.transform.rotation);
    }
}
