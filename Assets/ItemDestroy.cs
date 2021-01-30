using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ItemDestroy : MonoBehaviour
{

    // アイテム情報
    private ItemGenerator Item;
    // カメラの距離
    private float difference;

    // Use this for initialization
    void Start()
    {

    }

    void Update()
    {

        Camera camera = Camera.main;

        if (camera.transform.position.z> gameObject.transform.position.z)
        {
            Destroy(gameObject);
        }
    }
}

