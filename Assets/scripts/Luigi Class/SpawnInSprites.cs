


using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class SpawnInSprites : MonoBehaviour
{
    public GameObject Bug;
    public GameObject Hu;
    public GameObject Cone;
    public GameObject Ham;

    
    public Vector3 randomRange;
    public Vector3 randomDirection;
   

    public int bugAmount;
    
 
    
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bugAmount = Random.Range(15, 20);
        Debug.Log("bug");
        randomDirection = new Vector3(Random.Range(-1, 1), Random.Range(-1, 1), 0).normalized;


    }

    // Update is called once per frame
    void Update()
    {
        transform.position = 

        if (bugAmount > 0)
        {
            SpawnIn();
            
        }
       
    }

    public void SpawnIn()
    {
        randomRange = new Vector3(Random.Range(-8f,8f), Random.Range(-3f,5f), 0);
       
        if (bugAmount > 0)
        {
            GameObject go = Instantiate(Bug);
            go.transform.position = randomRange;
            bugAmount -= 1;
            Bug.transform.position += randomDirection * speed * Time.deltaTime;
        }




    }
}
