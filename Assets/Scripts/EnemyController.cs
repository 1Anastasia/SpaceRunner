using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    public float speed = 1f;
    public float widthBG = 5f;

    void Update()
    {
        transform.Translate(0f, -speed * Time.deltaTime, 0f);
        if (transform.position.y < -8f)
        {
            Destroy(gameObject);
        }
    }
}
