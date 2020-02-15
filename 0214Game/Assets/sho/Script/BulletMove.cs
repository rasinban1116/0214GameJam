using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    public GameObject bullet;
    public float BulletSpeed = 0;


    Vector3 Angle;
    private GameObject Player;
    private Vector3 PlayerPos;



    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
    
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPos = Player.transform.position;

        var time = Time.deltaTime;
        float Rstick_H = Input.GetAxis("Horizontal2");
        float Rstick_V = Input.GetAxis("Vertical2");

        if (Rstick_H != .0f || Rstick_V != .0f)
        {
            var direction = new Vector3(Rstick_H, Rstick_V,0);
         // 向きの生成（Z成分の除去と正規化）
         Vector3 shotForward = Vector3.Scale((direction*Time.deltaTime), new Vector3(1, 1, 0)).normalized;
         // 弾（ゲームオブジェクト）の生成
         GameObject clone = Instantiate(bullet, PlayerPos, Quaternion.identity);
         // 弾に速度を与える
         clone.GetComponent<Rigidbody2D>().velocity = shotForward * BulletSpeed;
        }
    }


}
