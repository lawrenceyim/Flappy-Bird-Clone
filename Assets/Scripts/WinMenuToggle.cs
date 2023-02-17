using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CanvasGroup))] 
public class WinMenuToggle : MonoBehaviour
{
    public CanvasGroup canvasGroup;
    void Awake()
    {
        // this.GetComponent<CanvasGroup>();
        // if (canvasGroup == null) {
        //     Debug.LogError("Canvas Group not found");
        // }
        canvasGroup.interactable = false;
        canvasGroup.blocksRaycasts = false;
        canvasGroup.alpha = 0f;
    }

    public void GameWon() {
        Time.timeScale = 0f;
            canvasGroup.interactable = true;
            canvasGroup.blocksRaycasts = true;
            canvasGroup.alpha = 1f;
    }
}
