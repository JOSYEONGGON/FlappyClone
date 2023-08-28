using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePipe : MonoBehaviour
{
    public GameObject pipe;
    public float timeDiff = 1;
     float timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > timeDiff)
        {
            GameObject newpipe = Instantiate(pipe); // »ý¼º
            newpipe.transform.position = new Vector3 (1.52F, Random.Range(-2.95F, 4.31F), 0);
            timer = 0;
            Destroy(newpipe, 10.0F);
        }
    }
}
