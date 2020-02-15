using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "wall")
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        float Rstick_H = Input.GetAxis("Horizontal2");
        float Rstick_V = Input.GetAxis("Vertical2");
        var direction = new Vector3(Rstick_H, Rstick_V, 0);
        var rotation = Quaternion.LookRotation(Vector3.forward, direction);
        transform.localRotation = rotation;
    }

    // Update is called once per frame
    void Update()
    {

    }

}
