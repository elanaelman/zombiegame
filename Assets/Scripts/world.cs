using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class world : MonoBehaviour
{
    public int tick = 0;
    public int ticksPerStep = 1000;
    public zombie zombiePrefab;
    
    private List<zombie> zombies = new List<zombie>();

    // Start is called before the first frame update
    void Start()
    {
        zombies.Add(Instantiate(zombiePrefab));
    }

    // Update is called once per frame
    void Update()
    {
        //tick++;
        //if (tick % ticksPerStep == 0)
        //{
        //    foreach (zombie z in zombies)
        //    {
        //        z.Turn();
        //    }
        //}
    }
}
