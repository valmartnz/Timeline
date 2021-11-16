using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
public class ClickableObjectHandler : MonoBehaviour
{
    [SerializeField] private DialogueUI dialogueUI;
    [SerializeField] private GameObject[] clickableObjects;
    [SerializeField] private UnityEvent[] objectEvents;
    // Start is called before the first frame update
    void Start()
    {
        for (int i=0; i < clickableObjects.Length; i++){
            //WHY IN THE WORLD IS THE LAST I ENDING UP AS A 1???? HOW THE HELL
            clickableObjects[i].GetComponentInChildren<Button>().onClick.AddListener( () => OnPickedResponse(i-1));
        }
    }

    private void OnPickedResponse(int index){
        if (dialogueUI.IsOpen) return;
        if (index>= objectEvents.Length) return;
        //Debug.Log();
        //if (!dialogueUI.IsOpen && index < objectEvents.Length) objectEvents[index].Invoke();
        objectEvents[index].Invoke();
    }
}
