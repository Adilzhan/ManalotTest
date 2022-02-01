using System;
using UnityEngine;
using UnityEngine.UI;

public class WindowManager : MonoBehaviour
{   
    public Button windowOpenButton;
    public Button closeButton;
    public GameObject windowPrefab;
    
    private GameObject _currentWindow;
    private void Start()
    {
        windowOpenButton.onClick.RemoveAllListeners();
        closeButton.onClick.RemoveAllListeners();
        
        windowOpenButton.onClick.AddListener(CreateWindow);
        closeButton.onClick.AddListener(DestroyWindow);
    }
    
    private void CreateWindow()
    {
        _currentWindow = Instantiate(windowPrefab,transform.position , Quaternion.identity,transform);
        HideButton(windowOpenButton, false);
    }

    private void HideButton(Button btn,bool state)
    {
        btn.gameObject.SetActive(state);
    }

    private void DestroyWindow()
    {
        Destroy(_currentWindow);
        HideButton(windowOpenButton, true);
    }
}
