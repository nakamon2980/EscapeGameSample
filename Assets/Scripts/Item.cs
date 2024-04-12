using System;
using UnityEngine;

[Serializable]
public class Item
{
    public enum Type
    {
        Cube,
        Ball,
    }

    public Type type;       // 種類
    public Sprite sprite;   // slotに表示する画像

    public Item(Type type, Sprite sprite)
    {
        this.type = type;
        this.sprite = sprite;
    }

}
