using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    public GameObject gameObjectPanel;
    public GameObject gameObjectImage;
    public Sprite Newsprite;

    public void Close()
    {
        gameObjectPanel.SetActive(false);
    }

    public void ChangeImage()
    {
        gameObjectImage.GetComponent<Image>().sprite = Newsprite;
    }
}