using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetObj : MonoBehaviour
{
    [SerializeField] GameObject setObject;
    [SerializeField] Item.Type useItem;

    // このオブジェクトをクリックしたら
    public void OnClickThis()
    {
        // 適切なアイテムを選択した状態で
        bool hasItem = ItemBox.instance.TryUseItem(useItem);
        if(hasItem)
        {
            // アイテムを表示する
            setObject.SetActive(true);

        }
    }


}
