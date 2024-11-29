using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{
    public GameObject prefab;
    public float spacing = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
          for (int i = 0; i < 10; i++)
        {
            // Calculate the position for each street lamp
            Vector3 position = transform.position + new Vector3(i * spacing, 0, 0);
            
            // Instantiate the street lamp at the calculated position
            Instantiate(prefab, position, transform.rotation);
        }  
    }

    // Update is called once per frame
    void Update()
    {
     if(Input.GetKeyDown(KeyCode.B))
     {
          Instantiate(prefab);
     }
     if(Input.GetKeyDown(KeyCode.Space))
     {
          Instantiate(prefab,transform.position,transform.rotation);
     }
    }
}
