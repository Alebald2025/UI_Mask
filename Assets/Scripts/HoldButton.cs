using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class HoldButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public Image progressFill;
    public GameObject targetObject;
    public float holdTime = 2f;

    private float timer = 0f;
    private bool holding = false;

    void Update()
    {
        if (holding)
        {
            timer += Time.deltaTime;
            progressFill.fillAmount = timer / holdTime;

            if (timer >= holdTime)
            {
                targetObject.SetActive(!targetObject.activeSelf);
                ResetProgress();
            }
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        holding = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        ResetProgress();
    }

    void ResetProgress()
    {
        holding = false;
        timer = 0f;
        progressFill.fillAmount = 0f;
    }


    public void Salir()
    {
        Application.Quit();
    }
}
