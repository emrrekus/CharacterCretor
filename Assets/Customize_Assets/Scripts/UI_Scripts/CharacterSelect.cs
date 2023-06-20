using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CharacterSelect : MonoBehaviour
{
    [SerializeField] private CharactersSO _charactersSo;
    [SerializeField] private CharacterIdSO _characterIdSo;
    [SerializeField] private TMP_Text[] characterSelectText;
    [SerializeField] private GameObject[] characterSelectButton;
    [SerializeField] private GameObject readyButton;
    [SerializeField] private GameObject editButton;

    private TMP_Text _playerText;
    private int _characterID;
    private int _characterGenderID;
    public int CharacterId => _characterID;


    private void Awake()
    {
        ButtonClosed();
    }

    private void Update()
    {
        ButtonActivete();
    }

    public void GetCharacterId(int characterId)
    {
        _characterID = characterId;

        _characterGenderID = _charactersSo._Characters[characterId].gender;
        PlayerPrefs.SetInt("Gender", _characterGenderID);
        _characterIdSo._characterId = CharacterId;
    }

    
    //Oyun başlamadan önce KarakterSeçme ekranında ki Edit ve Ready Butonlarını pasif yparak eğer herhangi bir karakter ataması sağlanılmadıysa
    // Bu işlevlerin kapanmasını sağlıyoruz.
    private void ButtonClosed()
    {
        readyButton.SetActive(false);
        editButton.SetActive(false);

        for (int i = 0; i < characterSelectButton.Length; i++)
        {
            characterSelectButton[i].SetActive(false);
        }
    }
    
    
    //Oyun içerisinde mevcutta karakter var ise ve ya yeni karakter oluşturduysa. Mevcut karakter sayısına göre button oluşturulup 
    //Edit ve Ready buttonları aktif ediyoruz.
    private void ButtonActivete()
    {
        for (int i = 0; i < _charactersSo._Characters.Count; i++)
        {
            characterSelectText[i].text = $"Player{i + 1}";
            characterSelectButton[i].SetActive(true);
            readyButton.SetActive(true);
            editButton.SetActive(true);
        }
    }
}