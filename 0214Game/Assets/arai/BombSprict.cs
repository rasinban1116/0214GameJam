using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombSprict : MonoBehaviour
{
    public float Scale;
    public int hp;

    public GameObject BombBullet;

    private Vector3 SetPos;
    // Start is called before the first frame update
    void Start()
    {
        // ボムの大きさの設定
        this.transform.localScale = new Vector3(Scale, Scale, 1.0f);

        SetPos = new Vector3(0.0f, 0.0f, 0.0f);
        transform.position = SetPos;

    }

    // Update is called once per frame
    void Update()
    { 

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // プレイヤーの弾に当たったら消滅
        if(collision.gameObject.tag == "Player")
        {
            for(int i = 0; i < 50; i++)
            {
               Instantiate(BombBullet, this.transform.position, Quaternion.identity);
            }
            Destroy(this.gameObject);
        }
        // 爆弾の弾に当たったらHPを減らす
        if(collision.gameObject.tag == "BombBullet")
        {
            hp -= 1;
            // 数回爆弾の弾に当たったら消滅
            if(hp <= 0)
            {
             Destroy(this.gameObject);
            }
        }
    }
}
