using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombie : MonoBehaviour
{
    public int x;
    public int y;

    private Vector3Int pos;

    private GridLayout gridLayout;
    private world w;


    // Start is called before the first frame update
    void Start()
    {
        //w = GameObject.Find("Grid").GetComponent<world>();
        //gridLayout = transform.parent.GetComponentInParent<GridLayout>();
        //pos = new Vector3Int(x, y, (int) transform.position.z);
        //transform.position = gridLayout.CellToWorld(pos);
    }

    // Update is called once per frame
    void Update()
    {
        //if (w.ticks % w.ticksPerStep == 0)
        //{
        //    Turn();
        //}
    }

    public void Turn() {
        //pos.y -= 1;
        //transform.position = gridLayout.CellToWorld(pos);
    }

}
