using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove2 : MonoBehaviour
{
    public GameObject bullet;
    public float BulletSpeed = 0;

    public float cooltime = 0;
    private float deltatime = 0;
    Vector3 Angle;
    public GameObject Player;
    private Vector3 PlayerPos;



    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        PlayerPos = Player.transform.position;
        float Rstick_H = Input.GetAxis("Player2Horizontal2");
        float Rstick_V = Input.GetAxis("Player2Vertical2");
        var time = Time.deltaTime;

        deltatime += time;
        // Debug.Log(deltatime);
        if (Rstick_H != .0f || Rstick_V != .0f)
        {

            if (deltatime >= cooltime)
            {
                var direction = new Vector3(Rstick_H, Rstick_V, 0);
                Vector3 shotForward = Vector3.Scale((direction * Time.deltaTime), new Vector3(1, 1, 0)).normalized;
                GameObject clone = Instantiate(bullet, PlayerPos, Quaternion.identity);
                clone.GetComponent<Rigidbody2D>().velocity = shotForward * BulletSpeed;
                deltatime = 0;

            }

        }


    }


}
