using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    public float speed = 1f;
    public float widthBG = 5f;
    public List<GameObject> shots;
    public float delay = 5f;
    public float speedS = 2F;

    void Start()
    {
        StartCoroutine(Generator());
    }

    void Update()
    {
        transform.Translate(0f, -speed * Time.deltaTime, 0f);
        if (transform.position.y < -8f)
        {
            Destroy(gameObject);
        }
    }

    IEnumerator Generator()
    {
        while (true)
        {
            yield return new WaitForSeconds(delay);
            var shot = Instantiate(shots[Random.Range(0, shots.Count)]);
            shot.transform.SetParent(transform, false);
            var deltaY = speed * Time.deltaTime;
            shot.transform.localPosition = new Vector3(0, deltaY, 0);
        }
    }
}
