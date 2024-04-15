using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour
{
    // slotsにslot要素をコードから入れる方法
    [SerializeField] Slot[] slots;
    [SerializeField] Slot selectedSlot = null;

    // どこでも実行できる
    public static ItemBox instance;
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            slots = GetComponentsInChildren<Slot>();
        }
    }

    // ClickObjがクリックされたら、スロットにアイテムを渡す
    public void SetItem(Item item)
    {

        foreach(Slot slot in slots)
        {
            if(slot.IsEmpty())
            {
                slot.SetItem(item);
                break;
            }
        }
    }

    public void OnselectSlot(int position)
    {
        // 一旦全てのスロットの選択パネルを非表示
        foreach(Slot slot in slots)
        {
            slot.HideBGPanel();

        }

        selectedSlot = null;

        // 選択されたスロットの選択パネルを表示
        if(slots[position].Onselected())
        {
            selectedSlot = slots[position];
        }
    }

    // アイテムの使用を試みる＆使えるなら使ってしまう
    public bool TryUseItem(Item.Type type)
    {
        // 選択スロットがあるかどうか
        if(selectedSlot == null)
        {
            return false;
        }
        if(selectedSlot.GetItem().type == type)
        {
            selectedSlot.SetItem(null);
            selectedSlot.HideBGPanel();
            selectedSlot = null;
            return true;
        }
        return false;

    }


    public Item GetSelectedItem()
    {
        if(selectedSlot == null)
        {
            return null;
        }
        return selectedSlot.GetItem();
    }

}
