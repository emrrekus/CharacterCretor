using System;
using System.Collections;
using System.Collections.Generic;
using CharacterCretor.Abstracts;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;
using Update = Unity.VisualScripting.Update;

[System.Serializable]
public class CharacterBodyPartData
{
    public Mesh Mesh;
    public Material Material;
}
[System.Serializable]
public class CharacterAccessoryPartData
{
    public Mesh Mesh;
    public Material Material;
}

public class CharacterSO : ScriptableObject
{

    private static CharacterSO intance;
    
    public static CharacterSO GetInstance()
    {
        if (intance == null)
        {
            intance = new CharacterSO();
        }
        return intance;
    }
    public Dictionary<int, CharacterBodyPartData> _characterBodyPartDatas = new Dictionary<int, CharacterBodyPartData>();

    public Dictionary<int, CharacterAccessoryPartData> _characterAccessoryPartDatas = new Dictionary<int, CharacterAccessoryPartData>();

    public int gender;
    
    
    
    //Karakterimizin Body ve Aksesuarları farklı mesh tipleri ile çalıştığı için bunları tutabilmek adına 2 farklı class oluşturup bu class
    //tiplerinde Dictionary oluşturduk. Oluşturduğumuz class tiplerini yenileyerek Scriptableobject içerisinde atanan verilerin tutulmasını sağladık.
    
    [Header("Body and Dress Customize")] 
    public CharacterBodyPartData _head = new CharacterBodyPartData();
    public CharacterBodyPartData _body = new CharacterBodyPartData();
    public CharacterBodyPartData _hand  = new CharacterBodyPartData();
    public CharacterBodyPartData _legs  = new CharacterBodyPartData();
    public CharacterBodyPartData _feet  = new CharacterBodyPartData();



    [Header("Body and Accesories Customize")]
    public CharacterAccessoryPartData _brow = new CharacterAccessoryPartData();
    public CharacterAccessoryPartData _eyes = new CharacterAccessoryPartData();
    public CharacterAccessoryPartData _beard= new CharacterAccessoryPartData();
    public CharacterAccessoryPartData _hair= new CharacterAccessoryPartData();
    public CharacterAccessoryPartData _mouth= new CharacterAccessoryPartData();
    public CharacterAccessoryPartData _bracerRight= new CharacterAccessoryPartData();
    public CharacterAccessoryPartData _bracerLeft= new CharacterAccessoryPartData();
    public CharacterAccessoryPartData _hat= new CharacterAccessoryPartData();
    public CharacterAccessoryPartData _headBand= new CharacterAccessoryPartData();
    public CharacterAccessoryPartData _helmet= new CharacterAccessoryPartData();
    public CharacterAccessoryPartData _neclaces= new CharacterAccessoryPartData();
    public CharacterAccessoryPartData _pauldronRight= new CharacterAccessoryPartData();
    public CharacterAccessoryPartData _pauldronLeft= new CharacterAccessoryPartData();
    public CharacterAccessoryPartData _poleynRight= new CharacterAccessoryPartData();
    public CharacterAccessoryPartData _poleynLeft= new CharacterAccessoryPartData();

   
    private void OnEnable()
    {
        
        AddDictionary();
      

    }

    
    private void AddDictionary()
    {
        _characterBodyPartDatas.Add(0, _head);
        _characterBodyPartDatas.Add(1, _body);
        _characterBodyPartDatas.Add(2, _hand);
        _characterBodyPartDatas.Add(3, _legs);
        _characterBodyPartDatas.Add(4, _feet);
        _characterAccessoryPartDatas.Add(0, _brow);
        _characterAccessoryPartDatas.Add(1, _eyes);
        _characterAccessoryPartDatas.Add(2, _beard);
        _characterAccessoryPartDatas.Add(3, _hair);
        _characterAccessoryPartDatas.Add(4, _mouth);
        _characterAccessoryPartDatas.Add(5, _bracerRight);
        _characterAccessoryPartDatas.Add(6, _bracerLeft);
        _characterAccessoryPartDatas.Add(7, _hat);
        _characterAccessoryPartDatas.Add(8, _headBand);
        _characterAccessoryPartDatas.Add(9, _helmet);
        _characterAccessoryPartDatas.Add(10, _neclaces);
        _characterAccessoryPartDatas.Add(11, _pauldronRight);
        _characterAccessoryPartDatas.Add(12, _pauldronLeft);
        _characterAccessoryPartDatas.Add(13, _poleynRight);
        _characterAccessoryPartDatas.Add(14, _poleynLeft);
    }

    
    
}