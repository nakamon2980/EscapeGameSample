using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomChange : MonoBehaviour
{
    [SerializeField] GameObject zoomCanvas;


    // zoomボタンを押したらZoomCanvasが表示される。
    // ZoomCanvasが表示されている状態でもう一度押したら、非表示になる。
    public void OnClickButton()
    {
        Debug.Log("zoomボタンを押した！");
        if(zoomCanvas.activeSelf == false)
        {
            zoomCanvas.SetActive(true);
        }
        else if(zoomCanvas.activeSelf == true)
        {
            zoomCanvas.SetActive(false);
        }
    }
}
