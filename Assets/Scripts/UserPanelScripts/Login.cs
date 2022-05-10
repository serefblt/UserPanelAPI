using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using PlayFab;
using PlayFab.ClientModels;
using UnityEngine.SceneManagement;

public class Login : MonoBehaviour
{
    InputController _inputController;
    [SerializeField] InputField _email, _password;
    [SerializeField] Button _loginButton;

    private void Awake()
    {
        _inputController = new InputController();
    }


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoginPanelControl()
    {
        _inputController.LoginPanel(_email, _password, _loginButton);
    }

    public void LoginOnClick()
    {
        PlayFabClientAPI.LoginWithEmailAddress(new LoginWithEmailAddressRequest() {Email = _email.text , Password = _password.text },
        Result => { SceneManager.LoadScene(1); },
        Error => { Debug.Log("Giriþ Baþarýsýz.."); });
    }
}
