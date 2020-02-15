using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombBulletSprict : MonoBehaviour
{

    private float movex; // ベクトル
    private float TimeCount = 2; // 時間
    private float Way; //向き

    public float speed;　// 弾の速度

    // Start is called before the first frame update
    void Start()
    {
        movex = Random.Range(0.0f, 1.0f);
        Way = Random.Range(0, 360);
        //movey = Random.Range(-1.0f, 1.0f);
        gameObject.transform.Rotate(0, 0, Way);
    }

    // Update is called once per frame
    void Update()
    {
        // タイマー
        TimeCount -= Time.deltaTime;

        // 向きに沿って進む
        Vector3 Velocity = gameObject.transform.rotation * new Vector3(movex * speed, 0, 0);
        gameObject.transform.position += Velocity * Time.deltaTime;
        // 2秒後に破壊される
        if (TimeCount < 0.0f)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // プレイヤーに衝突したらプレイヤーにダメージ＆このオブジェクトを消滅させる
        if (collision.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);

        }
        // 爆弾に消滅したら爆弾にダメージ＆このオブジェクトを消滅させる
        if (collision.gameObject.tag == "Bomb")
        {
            Destroy(this.gameObject);
        }

        // 壁に触れたら反射する
        if (collision.gameObject.tag == "Wall")
        {
            Way = Way += 90.0f;
            gameObject.transform.Rotate(0, 0, Way);

        }
    }
}