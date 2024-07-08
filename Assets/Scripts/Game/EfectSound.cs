using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class EfectSound : MonoBehaviour
{
    //nose puedo :c
    public static EfectSound Instance;

    public static event Action OnLose;
    public static event Action OnButtonHover;
    public static event Action OnWallDamage;
    public static event Action OnEnemyDeathSoundCoin;
    public static event Action OnArrowShot;

    public AudioClip buttonHoverSound;
    public AudioClip wallDamageSound;   
    public AudioClip enemyDeathSound;
    public AudioClip arrowShotSound;

    private AudioSource audioSource;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        OnButtonHover += PlayButtonHoverSound;
        OnWallDamage += PlayWallDamageSound;
        OnArrowShot += PlayArrowShotSound;
        OnLose += GoLose;
    }

    private void OnDestroy()
    {
        OnButtonHover -= PlayButtonHoverSound;
        OnWallDamage -= PlayWallDamageSound;
        OnArrowShot -= PlayArrowShotSound;
        OnLose -= GoLose;
    }

    private void GoLose()
    {
        SceneManager.LoadScene("Lose");
    }
    public void TriggerLose()
    {
        OnLose?.Invoke();   
    }

    public void TriggerEnemyDeathCoinSound()
    {
        OnEnemyDeathSoundCoin?.Invoke();
    }

    public void TriggerButtonHover()
    {
        OnButtonHover?.Invoke();
    }

    public void TriggerArrowShot()
    {
        OnArrowShot?.Invoke();
    }

    private void PlayButtonHoverSound()
    {
        PlaySound(buttonHoverSound);
    }

    private void PlayWallDamageSound()
    {
        PlaySound(wallDamageSound);
    }

    private void PlayEnemyDeathCoinSound()
    {
        PlaySound(enemyDeathSound);
    }

    private void PlayArrowShotSound()
    {
        PlaySound(arrowShotSound);
    }

    private void PlaySound(AudioClip clip)
    {
        if (audioSource != null && clip != null)
        {
            audioSource.PlayOneShot(clip);
        }
    }
}