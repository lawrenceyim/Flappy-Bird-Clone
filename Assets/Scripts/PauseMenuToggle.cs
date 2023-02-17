using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CanvasGroup))] 
public class PauseMenuToggle : MonoBehaviour
{
    public CanvasGroup canvasGroup;
    private bool gameOver;


    void Awake()
    {
        // this.GetComponent<CanvasGroup>();
        // if (canvasGroup == null) {
        //     Debug.LogError("Canvas Group not found");
        // }
        canvasGroup.interactable = false;
        canvasGroup.blocksRaycasts = false;
        canvasGroup.alpha = 0f;
        gameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver == false) {
            if (Input.GetKeyUp(KeyCode.Escape)) {
                if (canvasGroup.interactable) {
                    Time.timeScale = 1f;
                    canvasGroup.interactable = false;
                    canvasGroup.blocksRaycasts = false;
                    canvasGroup.alpha = 0f;
                } else {
                    Time.timeScale = 0f;
                    canvasGroup.interactable = true;
                    canvasGroup.blocksRaycasts = true;
                    canvasGroup.alpha = 1f;
                }
            } 
        }
    }

    public void LostGame() {
        gameOver = true;
        Time.timeScale = 0f;
        canvasGroup.interactable = true;
        canvasGroup.blocksRaycasts = true;
        canvasGroup.alpha = 1f;
    }
}
