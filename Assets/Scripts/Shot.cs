using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{

    public List<GameObject> shots;
    public float delay = 5f;
    public float speed = 0.5F;

    void Start()
    {
        StartCoroutine(Generator());
    }

    IEnumerator Generator()
    {
        while (true)
        {
            yield return new WaitForSeconds(delay);
            var shot = Instantiate(shots[Random.Range(0, shots.Count)]);
            shot.transform.SetParent(transform, false);
            var deltaY = speed * Time.deltaTime;
            shot.transform.position = new Vector3(0, deltaY, 0);
        }

      
    }
	
}
