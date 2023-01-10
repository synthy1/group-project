using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diologue_Trigger : MonoBehaviour
{
    public Message[] messages;
    public Actor[] actors;

    public void StartDialogue()
    {
        FindObjectOfType<Dialog_manager>().OpenDialogue(messages, actors);
    }
}


    //creates class for actor message and image
    [System.Serializable]
    public class Message
    {
        public int actorId;
        public string message;
    }
    
    [System.Serializable]
    public class Actor
    {
        public string name;
        public Sprite sprite;
    }

