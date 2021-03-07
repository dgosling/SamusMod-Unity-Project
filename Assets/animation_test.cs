using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animation_test : MonoBehaviour
{

    // Start is called before the first frame update
    Animator Animator;
    private int layer;
    void Start()
    {
        Animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.F))
        {
           layer = Animator.GetLayerIndex("Gesture, Override");
            Animator.PlayInFixedTime("chargeStart", layer,0f);
        }
    }
}
