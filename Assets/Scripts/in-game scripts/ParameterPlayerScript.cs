using UnityEngine;
using UnityEngine.UI;

public class ParameterPlayerScript : MonoBehaviour
{
    public int healthPoints;
    public bool playerIsAlive;
    public Animator animator;

    public Slider healthBar;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        healthPoints = 100;
        playerIsAlive = true;
        healthBar = GameObject.FindGameObjectWithTag("UI HP bar").GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (healthPoints <= 0)
        {
            playerIsAlive = false;
        }

        healthBar.value = healthPoints;
    }
}
