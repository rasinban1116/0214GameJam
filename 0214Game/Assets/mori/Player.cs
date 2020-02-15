using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private const float WorkSpeed = 0.3f;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    { 
        if (Input.GetAxis("Horizontal") > 0)
        {

            //右
            transform.Translate(WorkSpeed, 0, 0);
            //向き変更
            transform.localScale = new Vector3(1,1,1);
        }
        if(Input.GetAxis("Horizontal") < 0 )
        {
            //左
            transform.Translate(-WorkSpeed, 0, 0);
            //向き変更
            transform.localScale = new Vector3(-1,1,1);
        }
        if(Input.GetAxis("Vertical") > 0)
        {
            //上
            transform.Translate(0, WorkSpeed, 0);
        }

        if (Input.GetAxis("Vertical") < 0)
        {
            //下
            transform.Translate(0, -WorkSpeed, 0);
        }
    }
}
