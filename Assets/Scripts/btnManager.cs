using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btnManager : MonoBehaviour {
    public GameObject helpPanel;
    public GameObject leftBtns;
    public GameObject helpBtn;
    public KeyCode back;
    public void Update() {
        if (Input.GetKeyDown(back)) {
            helpPanel.GetComponent<Animator>().SetBool("helpinCheck", false);
            leftBtns.GetComponent<Animator>().SetBool("leftOutCheck", false);
            helpBtn.GetComponent<Animator>().SetBool("helpBtnOutCheck", false);
        }
    }
    public void playBtn() {
        Application.LoadLevel(1);
    }
    public void SettingsBtn() {
        Application.LoadLevel(2);
    }
    public void StoreBtn() {
        Application.LoadLevel(3);
    }
    public void HelpBtn() {
        helpPanel.GetComponent<Animator>().SetBool("helpinCheck", true);
        leftBtns.GetComponent<Animator>().SetBool("leftOutCheck",true);
        helpBtn.GetComponent<Animator>().SetBool("helpBtnOutCheck", true);
    }
}
