using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Hand : MonoBehaviour
{

    Animator handAnim;
    float gripTarget;
    float triggerTarget;
    float gripCurrent;
    float triggerCurrent;
    public float speed = 0;
    // Start is called before the first frame update
    void Start()
    {
        handAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        AnimateHand();
    }

    internal void SetGrip(float v)
    {
        gripTarget = v;
    }

    internal void SetTrigger(float v)
    {
        triggerTarget = v;
    }

    void AnimateHand()
    {
        if (gripCurrent != gripTarget)
        {

            gripCurrent = Mathf.MoveTowards(gripCurrent, gripTarget, Time.deltaTime * speed);
            handAnim.SetFloat("Grip", gripCurrent);
        }
        if (triggerCurrent != triggerTarget)
        {

            triggerCurrent = Mathf.MoveTowards(triggerCurrent, triggerTarget, Time.deltaTime * speed);
            handAnim.SetFloat("Trigger", triggerCurrent);
        }
       
    }
}
