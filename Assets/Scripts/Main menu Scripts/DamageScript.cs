using UnityEngine;

public class DamageScript : MonoBehaviour
{
    public BoxCollider2D damageCollider;
    public ParameterPlayerScript playerScript;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerScript = GameObject.FindGameObjectWithTag("MainCharacter").GetComponent<ParameterPlayerScript>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        playerScript.healthPoints -= 10;
    }
}
