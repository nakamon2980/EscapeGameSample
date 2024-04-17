using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    // カメラの切り替え
    // どこでどのカメラを有効にするのか
    // どこに
    // ・mainの全体を回転するカメラ
    // ・ズームした時のカメラ
    Camera currentCamera;
    Camera mainCamera;

    // どのファイルからでも関数の実行ができる
    public static CameraManager instance;
    private void Awake()
    {
        instance = this;
    }

    // 全体を回転するカメラのポジションを作成
    [SerializeField] Transform[] mainCameraTransforms = default;
    int currentMainPosition;
    void Start()
    {
        mainCamera = Camera.main;
        currentCamera = Camera.main;
        currentMainPosition = 0;
        currentCamera.transform.position = mainCameraTransforms[currentMainPosition].position;
        currentCamera.transform.rotation = mainCameraTransforms[currentMainPosition].rotation;
    }

    public void TurnLeft()
    {
        currentMainPosition--;
        if (currentMainPosition < 0)
        {
            currentMainPosition = mainCameraTransforms.Length - 1;
        }
        currentCamera.transform.position = mainCameraTransforms[currentMainPosition].position;
        currentCamera.transform.rotation = mainCameraTransforms[currentMainPosition].rotation;

    }

    public void TurnRight()
    {
        currentMainPosition++;
        if (currentMainPosition > mainCameraTransforms.Length - 1)
        {
            currentMainPosition = 0;
        }
        currentCamera.transform.position = mainCameraTransforms[currentMainPosition].position;
        currentCamera.transform.rotation = mainCameraTransforms[currentMainPosition].rotation;
    }


    public void SetZoomCamera(Camera camera)
    {
        currentCamera.gameObject.SetActive(false);
        camera.gameObject.SetActive(true);
        currentCamera = camera;
    }

    public void OnBackButton()
    {
        mainCamera.gameObject.SetActive(true);
        currentCamera.gameObject.SetActive(false);
        currentCamera = mainCamera;
    }

}