using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using PlayFab;
using PlayFab.ClientModels;
using UnityEngine.SceneManagement;

public class Register : MonoBehaviour
{
    InputController _inputController;
    [SerializeField] InputField _username, _email, _password, _repeatPassword;
    [SerializeField] Button _registerButton;
    [SerializeField] GameObject _registerPanel, _loginPanel;
    private void Awake()
    {
        _inputController = new InputController();
    }


    void Start()
    {
        
    }

   
    void Update()
    {
        
    }

    public void RegisterPanelControl()
    {
        _inputController.RegisterPanel(_username, _email, _password, _repeatPassword, _registerButton);
    }

    public void RegisterOnClick()
    {
        PlayFabClientAPI.RegisterPlayFabUser(new RegisterPlayFabUserRequest() {Username  = _username.text ,Email = _email.text, Password = _password.text , DisplayName = _username.text},
            Result => 
            {
                Debug.Log("Kayýt Baþarýlý");
            },  
            Error => { Debug.Log("Kayýt Baþarýsýz.."); });
    }
    public void RegisterLogin()
    {
        switch (_registerPanel.activeInHierarchy)
        {
            case true:
                _loginPanel.SetActive(true);
                _registerPanel.SetActive(false);
                break;
            default:
                _loginPanel.SetActive(false);
                _registerPanel.SetActive(true);
                break;
        }
    }
}
