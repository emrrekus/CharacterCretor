using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using CharacterCretor.Abstracts;
using Unity.VisualScripting;
using UnityEngine;
using Object = System.Object;


public abstract class AssetSO : ScriptableObject
{
    public Dictionary<int, Mesh[]> _accessorysMeshes = new Dictionary<int, Mesh[]>();
    public Dictionary<int, Mesh[]> _bodyMeshes = new Dictionary<int, Mesh[]>();
    public Dictionary<int, Material[]> _Materials = new Dictionary<int, Material[]>();
   
    
    public Mesh[] Hand;
    public Mesh[] Leg;
    public Mesh[] Beard;
    public Mesh[] Feet;
    public Mesh[] Bracer;
    public Mesh[] Hat;
    public Mesh[] HeadBand;
    public Mesh[] Helmet;
    public Mesh[] Neclaces;
    public Mesh[] Pauldron;
    public Mesh[] Poleyn;
    public Mesh[] Hair;
    public Mesh[] Brow;
    public Mesh[] Eye;
    public Mesh[] Mouth;
    public Mesh[] Body;
    public Material[] BodyColor;
    public Material[] LightSkinColor;
    public Material[] MediumSkinColor;
    public Material[] DarkSkinColor;

    private void OnEnable()
    {
        _accessorysMeshes.Add(0, Brow);
        _accessorysMeshes.Add(1, Eye);
        _accessorysMeshes.Add(2, Beard);
        _accessorysMeshes.Add(3, Hair);
        _accessorysMeshes.Add(4, Mouth);
        _accessorysMeshes.Add(5, Bracer);
        _accessorysMeshes.Add(6, Hat);
        _accessorysMeshes.Add(7, HeadBand);
        _accessorysMeshes.Add(8, Helmet);
        _accessorysMeshes.Add(9, Neclaces);
        _accessorysMeshes.Add(10, Pauldron);
        _accessorysMeshes.Add(11, Poleyn);
        _bodyMeshes.Add(1, Body);
        _bodyMeshes.Add(2, Hand);
        _bodyMeshes.Add(3, Leg);
        _bodyMeshes.Add(4, Feet);
        _Materials.Add(0, BodyColor);
        _Materials.Add(1,LightSkinColor);
        _Materials.Add(2,MediumSkinColor);
        _Materials.Add(3,DarkSkinColor);
    }

   
}