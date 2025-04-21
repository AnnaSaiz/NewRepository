using System.Threading;
using UnityEngine;

public class MoveThem : MonoBehaviour
{
    public float xSpeed = 15f;
    public float ySpeed = 15f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject go = transform.position(xSpeed * Time.deltaTime, ySpeed * Time.deltaTime, 0);
    }
}
