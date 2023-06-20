using System;
using System.Collections;
using System.Collections.Generic;
using CharacterCretor.Abstracts;
using UnityEngine;

public abstract class BaseCretor : MonoBehaviour
{
   
    
    
    public abstract void ChangeFaceModel(int modelId,int meshId);
    public abstract void ChangeFaceModelMaterialColor(int modelId, int colorId);
    public abstract void ChangeAccessoryModel(int modelId, int meshId);
    public abstract void ChangeBodyModel(int modelId, int meshId);
    public abstract void ChangeSkinColor(int modelId, int colorId);
    public abstract void ChangeAccessoryMaterialColor(int modelId, int colorId);
    public abstract void ChangeBodyMaterialColor(int modelId, int colorId);


}