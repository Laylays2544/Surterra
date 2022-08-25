using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeedSpawnTest : MonoBehaviour
{
    public GameObject ItemPrefab;
    public float Radius = 1;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) SpawnObjectAtRandom();
    }

    void SpawnObjectAtRandom() 
    {
        Vector3 randomPos = Random.insideUnitCircle * Radius;

        Instantiate(ItemPrefab, randomPos, Quaternion.identity);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;

        Gizmos.DrawWireSphere(this.transform.position, Radius);
    }
}
