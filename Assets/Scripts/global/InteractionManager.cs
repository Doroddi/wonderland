using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class InteractionManager : MonoBehaviour
{
    public static InteractionManager instance;


    [SerializeField]
    private InteractionElem[] interactions;

    public int nextInteraction;

    [SerializeField] public bool isCompleteQuest = true;

    private void Awake()    
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public InteractionElem GetInteractionElem()
    {
        Debug.Log("getnextElem");
        if (nextInteraction >= interactions.Length)
        {
            return new InteractionElem(-1, false);
        }
        return interactions[nextInteraction];
    }
    public void CompleteInteraction()
    {
        if (nextInteraction >= interactions.Length)
        {
            this.nextInteraction = -1;
            return;
        }
        if (isCompleteQuest == true)
        {
            this.nextInteraction++;
        }
    }

    public void CompelteQuest()
    {
        isCompleteQuest = true;
    }

    public void ReQuest()
    {
        isCompleteQuest = false;
    }

}
[System.Serializable]
public struct InteractionElem
{

    public InteractionElem(int o, bool d)
    {
        this.order = o;
        this.isDialog = d;
        this.autoStart = false;
    }
    public int order;
    public bool isDialog;
    public bool autoStart;
}