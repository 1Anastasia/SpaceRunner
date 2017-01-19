using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroController : MonoBehaviour
{

    public float speed = 1f;
    public float widthBG = 5f;

    void Update()
    {
        var horisontal = Input.GetAxis("Horizontal");

        if (horisontal != 0)
        {
            if ((horisontal > 0 && transform.position.x <= widthBG * 0.5f) ||
                (horisontal < 0 && transform.position.x >= -widthBG * 0.5f))
                transform.Translate(Vector3.right * speed * horisontal * Time.deltaTime);
        }
    }
		
	
}
