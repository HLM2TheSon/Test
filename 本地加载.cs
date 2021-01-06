using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class 本地加载 : MonoBehaviour
{
    // Start is called before the first frame update
    //void Start()
    //{
    //    //AssetBundles_ab
    //    //加载材质
    //    AssetBundle mt = AssetBundle.LoadFromFile("AssetBundles_ab/share");
    //    //加载物体
    //    AssetBundle ab = AssetBundle.LoadFromFile("AssetBundles_ab/cube.unity3d");
    //    GameObject cube = ab.LoadAsset<GameObject>("Cube");
    //    Instantiate(cube);


    //}




    //使用UnityWebRequest  方式加载服务器AB
    IEnumerator Start()
    {
        //本地路径
        string url = @"E:\Train\AssetBundle\AssetBundles_ab\capsule.unity3d";
        UnityWebRequest request = UnityWebRequestAssetBundle.GetAssetBundle(url);
        yield return request.SendWebRequest();
        AssetBundle ab = DownloadHandlerAssetBundle.GetContent(request);

        GameObject cube = ab.LoadAsset<GameObject>("Capsule");
        Instantiate(cube);
    }

}
