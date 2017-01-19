using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;

public class ObjectGenerator : MonoBehaviour
{

    public float generatorDelay = 1f;
    public float widthBG = 5f;
    public List<GameObject> enemies;

    void Start()
    {
        StartCoroutine(Generator());
    }

    IEnumerator Generator()
    {
        while (true)
        {
            yield return new WaitForSeconds(generatorDelay);
            var enemy = Instantiate(enemies[Random.Range(0, enemies.Count)]);
            enemy.transform.SetParent(transform, false);
            var deltaX = Random.Range(-widthBG * 0.5f, widthBG * 0.5f);
            enemy.transform.localPosition = new Vector3(deltaX, 0, 0);
        }
    }
}
