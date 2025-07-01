using UnityEngine;

[CreateAssetMenu(fileName = "CatFridge", menuName = "Scriptable Objects/CatFridge")]
public class CatFridge : ScriptableObject
{
    public new string name;

    public int healthPoints;
    public int attack;

    public Sprite sprite;
}
