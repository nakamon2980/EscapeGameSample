using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpObj : MonoBehaviour
{
    [SerializeField] Item.Type itemType;
    Item item;

    private void Start()
    {
        // itemTypeに応じてitemを生成する
        item = ItemGenerator.instance.Spawn(itemType);
    }

    // クリックしたら消す
    public void OnClickObj()
    {
        ItemBox.instance.SetItem(item);
        gameObject.SetActive(false);
        Debug.Log("アイテムをピックアップ！");
    }


}
