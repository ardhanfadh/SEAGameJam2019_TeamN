﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swipe_Catch : MonoBehaviour
{
    public bool isSwipe;

    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("SwipeController").GetComponent<SwipeControl>().SetMethodToCall(MyCallbackMethod);
    }

public void MyCallbackMethod(SwipeControl.SWIPE_DIRECTION iDirection)
{
    Debug.Log(iDirection);
    switch (iDirection)
    {
        /*
         * Tomake sure we detecting touch:
         *  - Touch
         * 
         * To make sure we detecting swipe atleast the condition that make sense are:
         *  - Down_Left
         *  - Down Right
         *  - Left
         *  - Right
         *  - Up Left
         *  - Up Right
         *  -------------------------------------------------------------------------
         */

        case SwipeControl.SWIPE_DIRECTION.SD_DOWN:
            break;
        case SwipeControl.SWIPE_DIRECTION.SD_DOWN_LEFT:
            print("Detecting: Swipe");
            isSwipe = true;
            break;
        case SwipeControl.SWIPE_DIRECTION.SD_DOWN_RIGHT:
            print("Detecting: Swipe");
            isSwipe = true;
            break;
        case SwipeControl.SWIPE_DIRECTION.SD_LEFT:
            print("Detecting: Swipe");
            isSwipe = true;
            break;
        case SwipeControl.SWIPE_DIRECTION.SD_RIGHT:
            print("Detecting: Swipe");
            isSwipe = true;
            break;
        case SwipeControl.SWIPE_DIRECTION.SD_TOUCH:
            print("Detecting Touch");
            isSwipe = false;
            break;
        case SwipeControl.SWIPE_DIRECTION.SD_UP:
            break;
        case SwipeControl.SWIPE_DIRECTION.SD_UP_LEFT:
            print("Detecting Swipe");
            isSwipe = true;
            break;
        case SwipeControl.SWIPE_DIRECTION.SD_UP_RIGHT:
            print("Detecting Swipe");
            isSwipe = true;
            break;
    }
}
<<<<<<< HEAD
    // Update is called once per frame
<<<<<<< HEAD
<<<<<<< HEAD
 
=======
>>>>>>> c4e32f16b75219cdd643c7590759dfe2aa6762b4
=======
=======
>>>>>>> parent of 75707a5... Testing, 3:47PM
    void Update()
    {
        
    }
<<<<<<< HEAD
>>>>>>> parent of 75707a5... Testing, 3:47PM
=======
>>>>>>> parent of 75707a5... Testing, 3:47PM
