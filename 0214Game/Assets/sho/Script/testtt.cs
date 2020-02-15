using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testtt : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // 接続されているコントローラの名前を調べる
        var controllerNames = Input.GetJoystickNames();

        // 一台もコントローラが接続されていなければエラー
        if (controllerNames[0] == "") Debug.Log("Error");
 
       // Debug.Log(controllerNames[2]);    
    }
}
