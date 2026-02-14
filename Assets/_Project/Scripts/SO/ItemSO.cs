using UnityEngine;

public abstract class ItemSO : ScriptableObject
{
    public int Id;
    public string Name;
    public string Description;

    public abstract void Use(GameObject player);

}
