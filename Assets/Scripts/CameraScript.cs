using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 2f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void LateUpdate()
    {
        if (target != null)
        {
            Vector3 newPos = new Vector3(target.position.x, target.position.y, -10f);
            transform.position = Vector3.Lerp(transform.position, newPos, smoothSpeed);
        }
    }
}
