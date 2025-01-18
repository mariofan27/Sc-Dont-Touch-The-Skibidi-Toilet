using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    [Header("Spawn Cube Object")]
    //Cube that is going to be spawn
    public GameObject spawnCube;
    //different of the game
    [Header("Default Difficulty")]
    public float difficulty = 40f;
    //Time for the next cube
    //to be spawned.
    float spawn;

    // Update is called once per frame
    void Update()
    {
        spawn = difficulty; // Time.deltaTime;
        //difficulty = Time.deltaTime * 4f;
        while (spawn > 0)
        {
            spawn -= 1;
            Vector3 v3pos = transform.position + new Vector3(Random.value * 40f - 20f, 0, Random.value * 40f - 20f);
            Quaternion qRotation = Quaternion.Euler(0, Random.value * 360f, Random.value * 30f);
            GameObject createObject = Instantiate(spawnCube, v3pos, qRotation);
            Debug.Log(spawn);
        }
    }
}
