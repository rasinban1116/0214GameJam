using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombSprict : MonoBehaviour
{
    public int hp; // 爆弾の弾に当たる用のHP
    public int Bornbomb; // 生成する爆弾の数

    public GameObject BombBullet;

    private int Way;
    private Vector3 SetPos;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // hpが０になったら消滅
        if (hp <= 0)
        {
            // 50個生成
            for (int i = 0; i < Bornbomb; i++)
            {
                Instantiate(BombBullet, this.transform.position, Quaternion.identity);
            }

            Destroy(this.gameObject);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // プレイヤーの弾に当たったら消滅
        if (collision.gameObject.tag == "Player")
        {
            // 当たった弾は消滅
            Destroy(collision.gameObject);

            // 50個生成
            for (int i = 0; i < Bornbomb; i++)
            {
                Instantiate(BombBullet, this.transform.position, Quaternion.identity);
            }
            // 自機の破壊
            Destroy(this.gameObject);
        }
        // 爆弾の弾に当たったらHPを減らす
        if (collision.gameObject.tag == "BombBullet")
        {
            hp -= 1;
        }

    }
}
