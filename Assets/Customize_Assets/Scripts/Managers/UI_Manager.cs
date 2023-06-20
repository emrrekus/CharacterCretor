using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace CharacterCretor.Managers
{
    public class UI_Manager : MonoBehaviour
    {
        private int _modelId;
        private int _colorId;
        private int _meshId;
        
        
        //Karakterin kategorize edilmiş özelliklerini CharacterCretor içerisinde eklemiş olduğumuz eventleri burada tetikliyoruz
        public void ChangeFaceModel()
        {
           EventManager.StartMethod(GameEvent.OnChangeFaceModel,_modelId,_meshId);
        }
        public void ChangeAccessoryModel()
        {
            EventManager.StartMethod(GameEvent.OnChangeAccessoryModel,_modelId,_meshId);
        }
        public void ChangeBodyModel()
        {
            EventManager.StartMethod(GameEvent.OnChangeBodyModel,_modelId,_meshId);
        }

        public void ChangeColorSkin()
        {
            EventManager.StartMethod(GameEvent.OnChangeSkinColor,_modelId,_colorId);
        }
        public void ModelChangeMaterial()
        {
            EventManager.StartMethod(GameEvent.OnChangeFaceModelMaterial,_modelId,_colorId);
        }
        public void AccessoryChangeMaterial()
        {
            EventManager.StartMethod(GameEvent.OnChangeAccessoryMaterial,_modelId,_colorId);
        }
        public void BodyModelChangeMaterial()
        {
            EventManager.StartMethod(GameEvent.OnChangeBodyModelMaterial,_modelId,_colorId);
        }
      
        

        public void SetModelId(int modelId)
        {
            _modelId = modelId;

        }
        public void SetMeshId(int meshId)
        {
            _meshId = meshId;
        }
        public void SetColorId(int colorId)
        {
            _colorId = colorId;
        }

        
       
    }
}