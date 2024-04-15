using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomChange : MonoBehaviour
{
    [SerializeField] GameObject zoomCanvas = default;
    [SerializeField] Transform objParent = default;
    GameObject zoomObj;

    // アイテムを選択していたら


    // zoomボタンを押したらZoomCanvasが表示される。
    public void OnClickZoomButton()
    {
        Debug.Log("zoomボタンを押した！");
        Item item = ItemBox.instance.GetSelectedItem();
        if(item != null)
        {
            Destroy(zoomObj); // 生成したズームオブジェクトを削除する
            zoomCanvas.SetActive(true);

            /* アイテムを表示
             * ObjParentにアイテムを生成する
             */
            GameObject zoomObjPrefab = ItemGenerator.instance.GetZoomItem(item.type);
            zoomObj = Instantiate(zoomObjPrefab, objParent); //アイテムをObjParentに生成する・zoomObjとして保持

        }

    }

    // ×ボタンを押したらZoomCanvasが非表示になる。
    public void OnClickCloseButton()
    {
        zoomCanvas.SetActive(false);
        Destroy(zoomObj);
    }
}
