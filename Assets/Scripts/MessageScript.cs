﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;

public enum PostingType {
    Scam,
    Default
}

public class MessageScript : MonoBehaviour
{
    /*
     * MessageTimer = ?
     * FollowersToDecrease = ?
     * isScam = ?
     */

    float messageTimer = 0.0f;
    int followersToDecrease = 20;
    public bool isScam = false;
    public PostingType messageType = PostingType.Default;
    public Swipe_Catch swipe_Catch;
    public GameObject GameOverScreen;

    private void Start()
    {
        swipe_Catch = GameObject.Find("Main Camera").GetComponent<Swipe_Catch>();
        GameOverScreen = GameObject.Find("GameOverScreen");
    }


    public void DestroySelf()
    {
        if(isScam == false)
        {
            GameObject reply = Instantiate(Manager.instance.replyGO, new Vector3(Input.mousePosition.x, Input.mousePosition.y), Quaternion.identity);
            reply.GetComponent<TextMeshProUGUI>().text = Manager.instance.replies[Random.Range(0, Manager.instance.replies.Length - 1)];
            reply.transform.SetParent(Manager.instance.Canvas.transform);
            reply.GetComponent<ReplyMessageSCript>().OnSpawn();
            reply.transform.DOScale(1.0f, 0.0f);
            reply.transform.DOLocalMoveY(reply.transform.position.y + 7, 1.0f);

            CancelInvoke("decreaseTimer");
            Destroy(gameObject);
        }
        else
        {
            if (swipe_Catch.isSwipe)
            {
                transform.DOLocalMoveX(-200, 1);
                StartCoroutine(Wait(1));
                transform.DOKill();
                Destroy(gameObject);
            }
            else
            {
                GameOverScreen.transform.DOLocalMoveX(12.811, 1);
            }
            print("GAMEOVER");
        }

        //This is what i think being better used while using Enum.

        /*
         * I'm using switch case to make it easier to adding 
         * function to each type of the messages
         * 
         * Default's Behaviors:
         * - 
         * 
         * Negative's Behaviors:
         * - minus 50 for the first negative, then x2 after that.
         * 
         * Positive's Behaviors:
         * - increase followers 5% for each positive behavior clicked
         * 
         * Scam's Behaviors:
         * - if tap on 3 times game will end and spawn negative post on the feed for everytime the player clicks on the scam message
         */

        switch(messageType)
        {
            case PostingType.Default:
                print("This is just Default Messages");
                transform.DOKill();
                Destroy(gameObject);
                break;
                /*
            case PostingType.Negative:
                print("This is just Negative Messages");
                transform.DOKill();
                Destroy(gameObject);
                break;
            case PostingType.Positive:
                print("This is just Positive Messages");
                transform.DOKill();
                Destroy(gameObject);
                break;
                */
            case PostingType.Scam:
                print("This is just Scam Messages");
                if (swipe_Catch.isSwipe)
                {

                }
                else
                {

                }
                transform.DOKill();
                Destroy(gameObject);

                //Restart Level
               // Application.LoadLevel(Application.loadedLevel);
                break;
        }
    }

    public void startCountdown(float length)
    {
        messageTimer = length;
        InvokeRepeating("decreaseTimer", 0, Time.deltaTime);
        Invoke("Stop", length);
        
        StartCoroutine(Wait(1));
        
        
    }

    void decreaseTimer()
    {
        messageTimer -= Time.deltaTime;
    }

    void Stop()
    {
        CancelInvoke("decreaseTimer");
        CancelInvoke("Punch");
        if(Manager.instance.followersCounter - followersToDecrease >= 0)
        {
            Manager.instance.followersCounter -= followersToDecrease;
        }
        else
        {
            Manager.instance.followersCounter = 0;
            Manager.instance.FollowersCounterTMPro.text = Manager.instance.followersCounter.ToString();
        }
        Destroy(gameObject);
    }

    void Punch()
    {
        gameObject.transform.DOPunchPosition(new Vector3(0.0f, 10.0f, 0.0f), 0.5f, 0, 0, false);
    }

    IEnumerator Wait(float time)
    {
        yield return new WaitForSeconds(time);
        InvokeRepeating("Punch", 0, 1.0f);
    }
}
<<<<<<< HEAD
<<<<<<< HEAD

>>>>>>> c4e32f16b75219cdd643c7590759dfe2aa6762b4
=======
}
>>>>>>> parent of 75707a5... Testing, 3:47PM
=======
}
>>>>>>> parent of 75707a5... Testing, 3:47PM
