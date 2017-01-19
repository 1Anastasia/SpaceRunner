using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

    public float speed = 0.1F;

    private void Update()
    {
        transform.Translate(0f, -speed * Time.deltaTime, 0f);
        if (transform.position.y < -8f)
        {
            Destroy(gameObject);
        }
    }
}
