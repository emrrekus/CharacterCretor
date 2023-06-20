using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Body : MonoBehaviour
{
    [SerializeField] protected SkinnedMeshRenderer _skinnedMeshRenderer;

    public SkinnedMeshRenderer SkinnedMeshRenderer
    {
        get { return _skinnedMeshRenderer; }
        set { _skinnedMeshRenderer = value; }
    }

    private void Awake()
    {
        _skinnedMeshRenderer = GetComponent<SkinnedMeshRenderer>();
    }
}
