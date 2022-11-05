using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacle : MonoBehaviour
{

    [SerializeField] private GameObject obstacle;
    [SerializeField] private float spawnRate;
    [SerializeField] private float minHeigth = -1;
    [SerializeField] private float maxHeight =  1;

    // Start is called before the first frame update
    private void OnEnable()
    {
        InvokeRepeating(nameof(Spawn),spawnRate, spawnRate);
    }

    private void OnDisable()
    {
        CancelInvoke(nameof(Spawn));
    }

    private void Spawn()
    {
        GameObject pipes = Instantiate(obstacle,transform.position,Quaternion.identity);
    }
}
