﻿using System.Collections;
using UnityEngine;

public class MyCameraController : MonoBehaviour
{

    //Unityちゃんのオブジェクト
    private GameObject unitychan;

    //Unityちゃんとカメラの距離
    private float difference;

    


    
    void Start()
    {

        //Unityちゃんのオブジェクトを取得
        this.unitychan = GameObject.Find("unitychan");

        //Unityちゃんとカメラの距離
        this.difference = unitychan.transform.position.z - this.transform.position.z;

        
        
    }

    // Update is called once per frame
    void Update()
    {
        //Unityちゃんの位置に合わせてカメラの位置を移動
        this.transform.position = new Vector3(0, this.transform.position.y, this.unitychan.transform.position.z - difference);

       
    }
}
