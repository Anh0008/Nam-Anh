using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnObstacle : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float spawnInterval = 1f;
    [SerializeField] private float radius = 10f;
    private float _timer;

    // Update is called once per frame
    private void Update()
    {
        _timer += Time.deltaTime;
        if ( _timer > spawnInterval )
        {
            //_timer-=spawnInterval;
            _timer = 0;
            Spawn();
        }
    }

    private void Spawn()
    {
        if (!ObjectPool.Instance.CanSpawn()) return;
        var obj = ObjectPool.Instance.PickOne(transform);
        var pos = Random.insideUnitSphere * radius;
        pos.y=Mathf.Abs(pos.y);
        obj.transform.position = pos;
        obj.SetActive(true);
    }
}
