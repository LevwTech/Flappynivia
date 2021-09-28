using System.Collections;
using System.Collections.Generic;
using System.IO.Pipes;
using UnityEngine;


public class wallgenerator : MonoBehaviour
{
    [SerializeField] GameObject walls;
    int timer = 100;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        timer++;
        if (timer >= 100)
        {
            timer = 0;
            GameObject wall = Instantiate(walls, new Vector2(walls.transform.position.x, walls.transform.position.y + Random.Range(-3, 3)), walls.transform.rotation);
            Destroy(wall, 5);
          
        }
    }
}