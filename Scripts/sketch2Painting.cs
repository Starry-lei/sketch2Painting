using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sketch2Painting : MonoBehaviour
{
    
    public string deviceName;
    WebCamTexture tex;
    // Use this for initialization
    IEnumerator Start()
    {
        //将请求获得麦克风或摄像机的许可权
        yield return Application.RequestUserAuthorization(UserAuthorization.WebCam);
        //使用Application.HasUserAuthorization来查询结果。
        //检查用户是否已授权在 WebPlayer 中使用网络摄像头或麦克风。
        if (Application.HasUserAuthorization(UserAuthorization.WebCam))
        {
            WebCamDevice[] devices = WebCamTexture.devices;
            deviceName = devices[0].name;
            tex = new WebCamTexture(deviceName, 400, 300, 12);
            GetComponent<Renderer>().material.mainTexture = tex;
            tex.Play();
        }
        else
        {
        }
    }
}
