using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour
{
    public NPC npc;

    bool isTalking = false;
    bool talkingNow = false;

    //float distance;
    float curResponseTracker = 0;

    public GameObject player;
    public GameObject dialogueUI;

    public Text npcName;
    public Text npcDialogueBox;
    public Text playerResponse;


    void Start()
    {
        dialogueUI.SetActive(false);
    }


    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            talkingNow = true;
            Debug.Log("We can maybe talk");
            Blabla();
        }
    }

    void Update()
    {
        if (talkingNow == true)
        {
            Blabla();
        }
    }

    void Blabla()
    {
        if(Input.GetAxis("Mouse ScrollWheel")<0f)
        {
            curResponseTracker++;
            if(curResponseTracker >= npc.playerDialogue.Length - 1)
            {
                curResponseTracker = npc.playerDialogue.Length - 1;
            }
        }

        else if (Input.GetAxis("Mouse ScrollWheel") > 0f)
        {
            curResponseTracker--;
            if (curResponseTracker <0)
            {
                curResponseTracker = 0;
            }
        }
        if (Input.GetKeyDown(KeyCode.E) && isTalking == false)
        {
            Debug.Log("Réussis à parler");
            StartConversation();
        }

        else if (Input.GetKeyDown(KeyCode.E) && isTalking == true)
        {
            Debug.Log("Fini de parler");
            EndDialog();
        }

        if (curResponseTracker == 0 && npc.playerDialogue.Length >= 0)
        {
            playerResponse.text = npc.playerDialogue[0];
            //playerResponse.text - npc.playerDialogue[0];
            if (Input.GetKeyDown(KeyCode.Return))
            {
                npcDialogueBox.text = npc.dialogue[1];
            }
        }
        else if (curResponseTracker == 1 && npc.playerDialogue.Length >=1 )
        {
            playerResponse.text = npc.playerDialogue[1];
            if(Input.GetKeyDown(KeyCode.Return))
            {
                npcDialogueBox.text = npc.dialogue[2];
            }
        }
        else if (curResponseTracker == 2 && npc.playerDialogue.Length >= 2)
        {
            playerResponse.text = npc.playerDialogue[2];
            if (Input.GetKeyDown(KeyCode.Return))
            {
                npcDialogueBox.text = npc.dialogue[3];
            }
        }
        else if (curResponseTracker == 3 && npc.playerDialogue.Length >= 3)
        {
            playerResponse.text = npc.playerDialogue[3];
            if (Input.GetKeyDown(KeyCode.Return))
            {
                npcDialogueBox.text = npc.dialogue[4];
            }
        }
        else if (curResponseTracker == 4 && npc.playerDialogue.Length >= 4)
        {
            playerResponse.text = npc.playerDialogue[4];
            if (Input.GetKeyDown(KeyCode.Return))
            {
                npcDialogueBox.text = npc.dialogue[5];
            }
        }
    }
    /*
    void OnMouseOver()
    {
        distance = Vector3.Distance(player.transform.position, this.transform.position);
        if (distance <= 2.5f)
        {
            if(Input.GetKeyDown(KeyCode.E) && isTalking == false)
            {
                StartConversation();
            }

            else if(Input.GetKeyDown(KeyCode.E) && isTalking == true)
            {
                EndDialog();
            }
        }
    }*/

    void StartConversation()
    {
        Debug.Log("Start Conversation");
        isTalking = true;
        curResponseTracker = 0;
        dialogueUI.SetActive(true);
        npcName.text = npc.name;
        npcDialogueBox.text = npc.dialogue[0];

    }

    void EndDialog()
    {
        isTalking = false;
        dialogueUI.SetActive(false);
    }
}
