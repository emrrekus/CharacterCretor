using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CharacterCretor.Abstracts
{
    public abstract class Accessorys : MonoBehaviour
    {
        [SerializeField] protected MeshFilter _meshFilter;
        [SerializeField] protected MeshRenderer _meshRenderer;


        public MeshFilter MeshFilter
        {
            get { return _meshFilter; }
            set { _meshFilter = value; }
        }

        public MeshRenderer MeshRenderer
        {
            get { return _meshRenderer;}
            set { _meshRenderer = value; }
        }
        
        private void Awake()
        {
            _meshFilter = GetComponent<MeshFilter>();
            _meshRenderer = GetComponent<MeshRenderer>();
        }


       
    }
   
}

