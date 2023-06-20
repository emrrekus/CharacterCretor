using System;
using System.Collections;
using System.Collections.Generic;
using CharacterCretor.Abstracts;
using CharacterCretor.Managers;
using Unity.VisualScripting;
using UnityEngine;
using Object = System.Object;


public class Character : Player
{
    
    private void Start()
    {
        CharacterItemAdd();
    }
    
    
    //Oluşturulan karakter özelliklerini tutuğumuz CharactersSo ScriptableObjectimiz içerisinden gelen character ıd ile ıtem bilgilerine ulaşıp
    //Scene'de ki karakterimizin ıtem bilgilerini güncelliyoruz
    private void CharacterItemAdd()
    {
        
        _characterSo = _charactersSo._Characters[_characterIdSo._characterId];


        for (int i = 0; i < _characterSo._characterBodyPartDatas.Count; i++)
        {
            if (_characterSo._characterBodyPartDatas[i].Mesh != null)
                characterBody[i].SkinnedMeshRenderer.sharedMesh = _characterSo._characterBodyPartDatas[i].Mesh;

            if (_characterSo._characterBodyPartDatas[i].Material != null)
                characterBody[i].SkinnedMeshRenderer.sharedMaterial = _characterSo._characterBodyPartDatas[i].Material;
        }

        for (int i = 0; i < _characterSo._characterAccessoryPartDatas.Count; i++)
        {
            if (_characterSo._characterAccessoryPartDatas[i].Mesh != null)
                characterAccessory[i].MeshFilter.sharedMesh = _characterSo._characterAccessoryPartDatas[i].Mesh;

            if (_characterSo._characterAccessoryPartDatas[i].Material != null)
                characterAccessory[i].MeshRenderer.sharedMaterial =
                    _characterSo._characterAccessoryPartDatas[i].Material;
        }
    }
   
}