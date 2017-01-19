using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundControler: MonoBehaviour
{

    public float partSitze;
    public float speed;
    public List<Transform> parts;

    void Start()
    {
        for (var i = 0; i < transform.childCount; ++i)
        {
            parts.Add(transform.GetChild(i));
        }
        for (var i = 0; i < parts.Count; ++i)
        {
            var pos = Vector3.zero;
            pos.y = partSitze * i;
            parts[i].transform.position = pos;
        }
    }

    void Update()
    {
        foreach (var part in parts)
        {
            var pos = part.position;
            pos.y -= speed * Time.deltaTime;
            if (pos.y <= -partSitze)
            {
                pos.y = partSitze * (parts.Count - 1);
            }
            part.position = pos;
        }
    }
}
