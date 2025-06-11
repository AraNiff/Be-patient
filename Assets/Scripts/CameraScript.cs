using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour
{
    public Transform transformCamera;
    public Component mainCharacter;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mainCharacter = GameObject.FindGameObjectWithTag("MainCharacter").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
