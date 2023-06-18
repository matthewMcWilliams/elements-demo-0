using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Emittor : MonoBehaviour
{
    [SerializeField] Transform spawnPoint, spawnFrom;
    [SerializeField] GameObject prefab;
    [SerializeField] protected Vector2 initialVelocity;

    public void SpawnObject()
    {
        CreateObject();
    }

    public GameObject CreateObject()
    {
        var @object = Instantiate(prefab, spawnFrom.position, Quaternion.identity, spawnPoint);
        if (@object.TryGetComponent<DestroyOnDirectionChange>(out DestroyOnDirectionChange d))
        {
            d.velocity = initialVelocity;
        }
        @object.GetComponent<Rigidbody2D>().velocity = initialVelocity;
        return @object;
    }

}
