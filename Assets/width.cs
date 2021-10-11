using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class width : MonoBehaviour
{
    // Start is called before the first frame update
    private TrailRenderer trail1;
    private Vector3 position;
    private float timer=0;
    private float timelimit;

    private void Start()
    {
        trail1 = this.GetComponent<TrailRenderer>();
        timelimit = trail1.time;
    }

    // Update is called once per frame
    private void Update()
    {
        position = this.transform.localPosition;
        if (timer < timelimit)
        {
            float wid = trail1.widthCurve.Evaluate(timer);
            //this.transform.localPosition = new Vector3(wid*.25,)
        }
    }
}

