using System;
using System.Collections;
using System.Collections.Generic;
using CharacterCretor.Managers;
using CharacterCretor.Objects.AccessoriesObject;
using CharacterCretor.Objects.BodyObjects;
using UnityEngine;

namespace CharacterCretor.Abstracts
{
    public abstract class Player : MonoBehaviour
    {
       protected Dictionary<int,Body>characterBody= new Dictionary<int,Body>();
       protected Dictionary<int,Accessorys>characterAccessory= new Dictionary<int,Accessorys>();
        
       
       protected CharacterSO _characterSo;
       [SerializeField] protected CharactersSO _charactersSo;
       [SerializeField] protected CharacterIdSO _characterIdSo;
       
       
       
       //Karakter üzerinde ki itemları katogorize ederek değişkenler oluşturuldu. Inherit edilen classta kullanılabilmesi için protected erişim belirleyici kullanıldı
        [Header("Body and Dress Customize")] 
        [SerializeField] protected Body _head;
        [SerializeField] protected Body _body;
        [SerializeField] protected Body _hand;
        [SerializeField] protected Body _legs;
        [SerializeField] protected Body _feet;


        [Header("Body and Accesories Customize")] 
        [SerializeField] protected Accessorys _brow;
        [SerializeField] protected Accessorys _eyes;
        [SerializeField] protected Accessorys _beard;
        [SerializeField] protected Accessorys _hair;
        [SerializeField] protected Accessorys _mouth;
        [SerializeField] protected Accessorys _bracerRight;
        [SerializeField] protected Accessorys _bracerLeft;
        [SerializeField] protected Accessorys _hat;
        [SerializeField] protected Accessorys _headBand;
        [SerializeField] protected Accessorys _helmet;
        [SerializeField] protected Accessorys _neclaces;
        [SerializeField] protected Accessorys _pauldronRight;
        [SerializeField] protected Accessorys _pauldronLeft;
        [SerializeField] protected Accessorys _poleynRight;
        [SerializeField] protected Accessorys _poleynLeft;

        private void Awake()
        {
            AddPlayerDictionary();

        }

        private void AddPlayerDictionary()
        {
            characterBody.Add(0, _head);
            characterBody.Add(1, _body);
            characterBody.Add(2, _hand);
            characterBody.Add(3, _legs);
            characterBody.Add(4, _feet);

            characterAccessory.Add(0, _brow);
            characterAccessory.Add(1, _eyes);
            characterAccessory.Add(2, _beard);
            characterAccessory.Add(3, _hair);
            characterAccessory.Add(4, _mouth);
            characterAccessory.Add(5, _bracerRight);
            characterAccessory.Add(6, _bracerLeft);
            characterAccessory.Add(7, _hat);
            characterAccessory.Add(8, _headBand);
            characterAccessory.Add(9, _helmet);
            characterAccessory.Add(10, _neclaces);
            characterAccessory.Add(11, _pauldronRight);
            characterAccessory.Add(12, _pauldronLeft);
            characterAccessory.Add(13, _poleynRight);
            characterAccessory.Add(14, _poleynLeft);
        }


        
       
       
    }
}