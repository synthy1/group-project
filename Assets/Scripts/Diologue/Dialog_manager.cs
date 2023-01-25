using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialog_manager : MonoBehaviour
{
    [Header("Refrences")]
    public Image actorImage;
    public Text actorName;
    public Text messageText;
    public AudioSource npc;
    public RectTransform backgroundBox;

    [Header("Arrays")]
    //arrays storing the current speaking actors and messages said
    Message[] currentMessages;
    Actor[] currentActors;
    Audio[] currentAudio;
    int activeMessage = 0;
    int activeAudio = 0;
    public static bool isActive = false;
    
    public void OpenDialogue(Message[] messages, Actor[] actors , Audio[] audios)
    {
        currentMessages = messages;
        currentActors = actors;
        currentAudio = audios;
        activeMessage = 0;
        activeAudio = 0;
        isActive = true;

        npc.enabled = true;
        DisplayMessage();
        backgroundBox.LeanScale(Vector3.one, 0.5f).setEaseInOutExpo();
    }

    private void DisplayMessage()
    {
        //sends correct message to text
        Message messageToDisplay = currentMessages[activeMessage];
        messageText.text = messageToDisplay.message;

        //sends correct actor to image
        Actor actorToDisplay = currentActors[messageToDisplay.actorId];
        actorName.text = actorToDisplay.name;
        actorImage.sprite = actorToDisplay.sprite;

        //send correct audio to audio source
        Audio audioToPlay = currentAudio[activeAudio];
        npc.PlayOneShot(audioToPlay.diologue);

        AnimateTextColor();
    }


    //calls next message in array
    public void NextMessage()
    {
        activeMessage++;
        activeAudio++;
        if (activeMessage < currentMessages.Length)
        {
            DisplayMessage();
        }
        else
        {
            backgroundBox.LeanScale(Vector3.zero, 0.5f).setEaseInOutExpo();
            npc.enabled = false;
            isActive = false;
        }
    }

    //animates text to show text update
    void AnimateTextColor()
    {
        LeanTween.textAlpha(messageText.rectTransform, 0, 0);
        LeanTween.textAlpha(messageText.rectTransform, 1, 0.5f);
    }

    // Start is called before the first frame update
    void Start()
    {
        backgroundBox.transform.localScale = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && isActive == true)
        {
            NextMessage();
        }
    }
}
