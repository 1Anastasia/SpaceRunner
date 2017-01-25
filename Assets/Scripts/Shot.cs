using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{

    public List<GameObject> shots;
    public float delay = 5f;
    public float speed = 0.5F;

    void Update()
    {
        var shotGo = Input.GetKeyDown("z");
        if (shotGo == true)
        {
            var shot = Instantiate(shots[Random.Range(0, shots.Count)]);
            shot.transform.position = transform.position;

        }
    }


	
}
