using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

[CreateAssetMenu(menuName = "Scriptable Object/Item")]
public class Item : ScriptableObject
{


    [Header("Only gameplay")]
    public TileBase tile;
    public ItemType itemType;
    public ActionType actionType;
    public Vector2Int range = new Vector2Int(5, 4);
    
    [Header("Only UI")]
    public bool stackable = true;
    public string name;
    public string description;

    [Header("Both")]
    public Sprite image;
}

public enum ItemType
{
    BuildingBlock,
    Tool
}

public enum ActionType
{
    Dig,
    Mine
}