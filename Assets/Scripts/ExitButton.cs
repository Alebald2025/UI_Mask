using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ExitButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public Image progressFill;
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
                Application.Quit();
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
