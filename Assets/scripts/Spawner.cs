using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    private float _Timer;

    public GameObject pipesPrefab;
    public float height;
    public float maxTime = 1f;

    private void Start()
    {
        var newPipes = Instantiate(pipesPrefab);
        var y = Random.Range(-height, height);

        newPipes.transform.position = new Vector2(0, y);
    }

    private void Update()
    {
        if (_Timer > maxTime)
        {
            var newPipes = Instantiate(pipesPrefab);
            var y = Random.Range(-height, height);

            newPipes.transform.position = new Vector2(0, y);
            Destroy(newPipes, 20f);

            _Timer = 0;
        }

        _Timer += Time.deltaTime;
    }


 private void Spawn()
 {
    var newPipes = Instantiate(pipesPrefab);
    var y = Random.Range(-height, height);

    newPipes.transform.position = new Vector2(Transform.position.x, y);
    Destroy(newPipes, 20f);
 }
}

