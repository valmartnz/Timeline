
using UnityEngine;
using System;

public class DialogueResponseEvents : MonoBehaviour
{
    [SerializeField] private DialogueObject dialogueObject;
    [SerializeField] private ResponseEvent[] events;
    public DialogueObject DialogueObject=> dialogueObject;
    public ResponseEvent[] Events => events;
    public void OnValidate()
   {
        if (dialogueObject == null) return;
        if (dialogueObject.Responses == null) return;
        if (events == null)
        {
            events = new ResponseEvent[dialogueObject.Responses.Length];
        }
        else
        {
            Array.Resize(ref events, dialogueObject.Responses.Length);
        }
       for (int i = 0; i < dialogueObject.Responses.Length; i++)
       {
           Response response = dialogueObject.Responses[i];
           if (events[i] != null)
           {
               events[i].name = response.ResponseText;
               events[i].DTag = dialogueObject.name;
               continue;
           }
           events[i] = new ResponseEvent() {name = response.ResponseText, DTag = dialogueObject.name};
       }     
   }
}