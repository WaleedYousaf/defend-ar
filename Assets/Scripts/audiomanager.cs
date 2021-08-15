using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audiomanager : MonoBehaviour {

    public GameObject musicSrc;
    public GameObject soundSrc;

    public GameObject soundOn;
    public GameObject soundOff;
    public GameObject musicOff;
    public GameObject musicOn;

	void Start () {
        PlayerPrefs.DeleteAll();
        if (!PlayerPrefs.HasKey("music"))
        {
            PlayerPrefs.SetInt("music", 1);
        }
        if (!PlayerPrefs.HasKey("sound"))
        {
            PlayerPrefs.SetInt("sound", 1);
        }
        if (PlayerPrefs.GetInt("music") == 1)
        {
            musicSrc.GetComponent<AudioSource>().Play();
            musicOn.SetActive(true);
            musicOff.SetActive(false);
        }
        else
        {
            musicSrc.GetComponent<AudioSource>().Stop();
            musicOn.SetActive(false);
            musicOff.SetActive(true);
        }
        if (PlayerPrefs.GetInt("sound") == 1)
        {
            soundOn.SetActive(true);
            soundOff.SetActive(false);
        }
        else
        {
            soundOn.SetActive(false);
            soundOff.SetActive(true);
        }
    }

    public void onMusicTurnOn() {
        musicOn.SetActive(true);
        musicOff.SetActive(false);
        PlayerPrefs.SetInt("music", 1);
        musicSrc.GetComponent<AudioSource>().Play();
        if (PlayerPrefs.GetInt("sound") == 1) {
            soundSrc.GetComponent<AudioSource>().Play();
        }
    }
    public void onMusicTurnOff() {
        musicOn.SetActive(false);
        musicOff.SetActive(true);
        PlayerPrefs.SetInt("music", 0);
        musicSrc.GetComponent<AudioSource>().Stop();
        if (PlayerPrefs.GetInt("sound") == 1)
        {
            soundSrc.GetComponent<AudioSource>().Play();
        }
    }
    public void onSoundTurnOn() {
        PlayerPrefs.SetInt("sound", 1);
        soundOn.SetActive(true);
        soundOff.SetActive(false);
        soundSrc.GetComponent<AudioSource>().Play();
    }
    public void onSoundTurnOff() {
        PlayerPrefs.SetInt("sound", 0);
        soundOn.SetActive(false);
        soundOff.SetActive(true);
    }
}
