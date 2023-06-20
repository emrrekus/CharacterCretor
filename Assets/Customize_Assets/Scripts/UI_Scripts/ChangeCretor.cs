using System;
using System.Collections;
using CharacterCretor.Abstracts;
using CharacterCretor.Managers;
using TMPro;
using UnityEditor;
using UnityEngine;


public class ChangeCretor : BaseCretor
{
    
   
    [SerializeField] private AssetSO _assetSo;
    [SerializeField] private AssetSO _femaleAssetSo;

     //Erkek Modele ait Atama yapılacak notları ve UI üzerinde değiştirilen itemın ismini görmesi için bu verileri alıyoruz   
    [Header("-------Male Models-------")]
    [SerializeField]
    private Accessorys[] _maleAccessorysModels;
    [SerializeField] private Body[] _maleBodyModels;
    [SerializeField] private TMP_Text[] _maleAccessoryTexts;
    [SerializeField] private TMP_Text[] _maleBodyTexts;
    
    //Kadın Modele ait Atama yapılacak notları ve UI üzerinde değiştirilen itemın ismini görmesi için bu verileri alıyoruz   
    [Header("-------Female Models-------")]
    [SerializeField]
    private Accessorys[] _femaleAccessorysModels;

    [SerializeField] private Body[] _femaleBodyModels;
    [SerializeField] private TMP_Text[] _femaleAccessoryTexts;
    [SerializeField] private TMP_Text[] _femaleBodyTexts;

    [SerializeField] private CharacterSO _characterSo;
    [SerializeField] private CharactersSO _charactersData;
    [SerializeField] private CharacterIdSO _characterIdSo;

  
    
    private int _skinId;
    private int _modelId;
    
 
    
    //UI Ekranında ki Create butonuna tıklandığında tetikleyip. CharacterSO scriptableobjectimiz tipinde yeni bir SO oluşturup
    //Bu bilgileri Change ekranında yaptığımız veya seçtiğimiz ıtemları bu SO İçerisine aktarıyoruz.
    //Yeni karakter oluşturulduğu için bu karakter CharactersSO Listimizin içerisine aktarıyoruz.
    // Sahnedeki örnek modelin ıtem bilgilerini null yaparak yeni bir karakter oluşturulması sağlandığında boş model gelmesini sağlıyoruz.
    public void CharacterCreate()
    {
        CharacterSO newCharacter = ScriptableObject.CreateInstance<CharacterSO>();
        string path = $"Assets/CharacterDatas/Character{(_charactersData._Characters.Count + 1)}.asset";
        _charactersData._Characters.Add(newCharacter);
        AssetDatabase.CreateAsset(newCharacter, path);
        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();
        newCharacter.gender = PlayerPrefs.GetInt("Gender");


        for (int i = 0; i < _characterSo._characterBodyPartDatas.Count; i++)
        {
            newCharacter._characterBodyPartDatas[i].Mesh = _characterSo._characterBodyPartDatas[i].Mesh;
            newCharacter._characterBodyPartDatas[i].Material = _characterSo._characterBodyPartDatas[i].Material;
            _characterSo._characterBodyPartDatas[i].Mesh = null;
            _characterSo._characterBodyPartDatas[i].Material = null;

        }
        for (int i = 0; i < _characterSo._characterAccessoryPartDatas.Count; i++)
        {
            newCharacter._characterAccessoryPartDatas[i].Mesh = _characterSo._characterAccessoryPartDatas[i].Mesh;
            newCharacter._characterAccessoryPartDatas[i].Material = _characterSo._characterAccessoryPartDatas[i].Material;
            _characterSo._characterAccessoryPartDatas[i].Mesh = null;
            _characterSo._characterAccessoryPartDatas[i].Material = null;
        }

       
    }
    
    //CharacterSelect UI'da edit butonu tetiklendiğinde çalışıyor olacak. Seçilen butonda ki ıd bilgisine göre
    //CharactersSO içerisindeki tutuğumuz Character listinin ıd numaralı objesini ataması sağlanacaktır.
    //Ardıdan modelin erkek yada kadın olduğu kontrol edilip ona göre sahnede ki modele verilerin işlenmesi sağlanacak.
    //Ve sahnede yapılan değişiklikler ilk başta atanan data üzerinde değişiklik sağlanıp mevcut data değiştirilecektir.
    public void CharacterEdit()
    {
        
        _characterSo = _charactersData._Characters[_characterIdSo._characterId];
        

        for (int i = 0; i < _characterSo._characterBodyPartDatas.Count; i++)
        {
            if (_characterSo._characterBodyPartDatas[i].Mesh != null)
            {
                if (PlayerPrefs.GetInt("Gender") == 1)
                {
                    _maleBodyModels[i].SkinnedMeshRenderer.sharedMesh = null;
                    _maleBodyTexts[i].text = _characterSo._characterBodyPartDatas[i].Mesh.name;
                    _maleBodyModels[i].SkinnedMeshRenderer.sharedMesh = _characterSo._characterBodyPartDatas[i].Mesh;
                }
                else if (PlayerPrefs.GetInt("Gender") == 2)
                {
                    _femaleBodyModels[i].SkinnedMeshRenderer.sharedMesh = null;
                    _femaleBodyTexts[i].text = _characterSo._characterBodyPartDatas[i].Mesh.name;
                    _femaleBodyModels[i].SkinnedMeshRenderer.sharedMesh = _characterSo._characterBodyPartDatas[i].Mesh; 
                }
                
            }


            if (_characterSo._characterBodyPartDatas[i].Material != null)
            {
                if (PlayerPrefs.GetInt("Gender") == 1)
                {
                    _maleBodyModels[i].SkinnedMeshRenderer.sharedMaterial = _characterSo._characterBodyPartDatas[i].Material;
                }
                else if (PlayerPrefs.GetInt("Gender") == 2)
                {
                    _femaleBodyModels[i].SkinnedMeshRenderer.sharedMaterial = _characterSo._characterBodyPartDatas[i].Material;
                }
            }
              
               
        }

        for (int i = 0; i < _characterSo._characterAccessoryPartDatas.Count; i++)
        {
            if (_characterSo._characterAccessoryPartDatas[i].Mesh != null)
            {
                if (PlayerPrefs.GetInt("Gender") == 1)
                {
                    _maleAccessorysModels[i].MeshFilter.sharedMesh = null;
                    _maleAccessoryTexts[i].text=_characterSo._characterAccessoryPartDatas[i].Mesh.name;
                    _maleAccessorysModels[i].MeshFilter.sharedMesh = _characterSo._characterAccessoryPartDatas[i].Mesh;
                }
                else if (PlayerPrefs.GetInt("Gender") == 2)
                {
                    _femaleAccessorysModels[i].MeshFilter.sharedMesh = null;
                    _femaleAccessoryTexts[i].text=_characterSo._characterAccessoryPartDatas[i].Mesh.name;
                    _femaleAccessorysModels[i].MeshFilter.sharedMesh = _characterSo._characterAccessoryPartDatas[i].Mesh;
                }
            }



            if (_characterSo._characterAccessoryPartDatas[i].Material != null)
            {

                if (PlayerPrefs.GetInt("Gender") == 1)
                {
                    _maleAccessorysModels[i].MeshRenderer.sharedMaterial = _characterSo._characterAccessoryPartDatas[i].Material;
                }
                else if (PlayerPrefs.GetInt("Gender") == 2)
                {
                    _femaleAccessorysModels[i].MeshRenderer.sharedMaterial = _characterSo._characterAccessoryPartDatas[i].Material;
                }
            }
        }


    }




    private void OnEnable()
    {
        EventManager.AddHandler(GameEvent.OnChangeBodyModelMaterial, ChangeBodyMaterialColor);
        EventManager.AddHandler(GameEvent.OnChangeAccessoryMaterial, ChangeAccessoryMaterialColor);
        EventManager.AddHandler(GameEvent.OnChangeSkinColor, ChangeSkinColor);
        EventManager.AddHandler(GameEvent.OnChangeBodyModel, ChangeBodyModel);
        EventManager.AddHandler(GameEvent.OnChangeAccessoryModel, ChangeAccessoryModel);
        EventManager.AddHandler(GameEvent.OnChangeFaceModelMaterial, ChangeFaceModelMaterialColor);
        EventManager.AddHandler(GameEvent.OnChangeFaceModel, ChangeFaceModel);
    }


    private void OnDisable()
    {
        EventManager.RemoveHandler(GameEvent.OnChangeBodyModelMaterial, ChangeBodyMaterialColor);
        EventManager.RemoveHandler(GameEvent.OnChangeAccessoryMaterial, ChangeAccessoryMaterialColor);
        EventManager.RemoveHandler(GameEvent.OnChangeSkinColor, ChangeSkinColor);
        EventManager.RemoveHandler(GameEvent.OnChangeBodyModel, ChangeBodyModel);
        EventManager.RemoveHandler(GameEvent.OnChangeAccessoryModel, ChangeAccessoryModel);
        EventManager.RemoveHandler(GameEvent.OnChangeFaceModelMaterial, ChangeFaceModelMaterialColor);
        EventManager.RemoveHandler(GameEvent.OnChangeFaceModel, ChangeFaceModel);
    }
    
    
    public void ForwardModelId()
    {
        _modelId++;
        if (_modelId > 5)
        {
            _modelId = 0;
        }
    }

    public void BackModelId()
    {
        if (_modelId > 0)
        {
            _modelId--;
        }
        else
        {
            _modelId = 5;
        }
    }


    public override void ChangeBodyModel(int modelId, int meshId)
    {
        //Cinsiyet Kontrolü sağlıyoruz
        if (PlayerPrefs.GetInt("Gender") == 1)
        {
            //Cinsiyet kontrolü sağlandıktan sonra Inspector üzerinde atama yaptığımız modelin bilgilerini Erkek ve Kadın model meshleri tutuğumuz dictionary üzerinden alıyoruz.
            _maleBodyTexts[modelId].text= _assetSo._bodyMeshes[meshId][_modelId].name;
            _maleBodyModels[modelId].SkinnedMeshRenderer.sharedMesh = _assetSo._bodyMeshes[meshId][_modelId];
            //CretorPaneli ise veri aktarımı sağlamak amaçlı SO objectine
            // Eğer Edit panelinden geliyorsa seçli olan SO Objectine veri yazıyoruz
            _characterSo._characterBodyPartDatas[modelId].Mesh = _maleBodyModels[modelId].SkinnedMeshRenderer.sharedMesh;
        }
        else if (PlayerPrefs.GetInt("Gender") == 2)
        {
            _femaleBodyTexts[modelId].text= _femaleAssetSo._bodyMeshes[meshId][_modelId].name;
            _femaleBodyModels[modelId].SkinnedMeshRenderer.sharedMesh = _femaleAssetSo._bodyMeshes[meshId][_modelId];
            _characterSo._characterBodyPartDatas[modelId].Mesh = _femaleBodyModels[modelId].SkinnedMeshRenderer.sharedMesh;
        }

    }

    public override void ChangeFaceModel(int modelId, int meshId)
    {
        if (PlayerPrefs.GetInt("Gender") == 1)
        {
            
            // Şapka,Saç,Kask,Kafabandı objelerinin üst üste gelmelerini engellemek amaçlı kontrol sağlayıp diğer seçimleri siliyoruz.
            if (modelId == 3)
            {
                ;
                for (int i = 7; i <= 9; i++)
                {
                    _maleAccessorysModels[i].MeshFilter.mesh = null;
                    _characterSo._characterAccessoryPartDatas[i].Mesh = null;
                }
            }
                
            _maleAccessoryTexts[modelId].text=_assetSo._accessorysMeshes[meshId][_modelId].name;
            _maleAccessorysModels[modelId].MeshFilter.mesh = _assetSo._accessorysMeshes[meshId][_modelId];
            _characterSo._characterAccessoryPartDatas[modelId].Mesh = _assetSo._accessorysMeshes[meshId][_modelId];
        }
        else if (PlayerPrefs.GetInt("Gender") == 2)
        {
            if (modelId == 3)
            {
                ;
                for (int i = 7; i <= 9; i++)
                {
                    _femaleAccessorysModels[i].MeshFilter.mesh = null;
                    _characterSo._characterAccessoryPartDatas[i].Mesh = null;
                }
            }
            
            _femaleAccessoryTexts[modelId].text=_femaleAssetSo._accessorysMeshes[meshId][_modelId].name;
            _femaleAccessorysModels[modelId].MeshFilter.mesh = _femaleAssetSo._accessorysMeshes[meshId][_modelId];
            _characterSo._characterAccessoryPartDatas[modelId].Mesh = _femaleAssetSo._accessorysMeshes[meshId][_modelId];
        }

    }

    public override void ChangeAccessoryModel(int modelId, int meshId)
    {
        int[] accessoryIndicesToNullify = { 3, 7, 8, 9 };
        if (PlayerPrefs.GetInt("Gender") == 1)
        {
            // Şapka,Saç,Kask,Kafabandı objelerinin üst üste gelmelerini engellemek amaçlı kontrol sağlayıp diğer seçimleri siliyoruz.
            if (((IList)accessoryIndicesToNullify).Contains(modelId))
            {
                foreach (int index in accessoryIndicesToNullify)
                {
                    if (index != modelId)
                    {
                        _maleAccessorysModels[index].MeshFilter.mesh = null;
                        _characterSo._characterAccessoryPartDatas[index].Mesh = null;
                    }
                }
            }
            
            _maleAccessoryTexts[modelId].text=_assetSo._accessorysMeshes[meshId][_modelId].name;
            _maleAccessorysModels[modelId].MeshFilter.mesh = _assetSo._accessorysMeshes[meshId][_modelId];
            _characterSo._characterAccessoryPartDatas[modelId].Mesh = _assetSo._accessorysMeshes[meshId][_modelId];
        }
        else if (PlayerPrefs.GetInt("Gender") == 2)
        {
            if (((IList)accessoryIndicesToNullify).Contains(modelId))
            {
                foreach (int index in accessoryIndicesToNullify)
                {
                    if (index != modelId)
                    {
                        _femaleAccessorysModels[index].MeshFilter.mesh = null;
                        _characterSo._characterAccessoryPartDatas[index].Mesh = null;
                    }
                }
            }
            
           _femaleAccessoryTexts[modelId].text= _femaleAssetSo._accessorysMeshes[meshId][_modelId].name;
            _femaleAccessorysModels[modelId].MeshFilter.mesh = _femaleAssetSo._accessorysMeshes[meshId][_modelId];
            _characterSo._characterAccessoryPartDatas[modelId].Mesh = _femaleAssetSo._accessorysMeshes[meshId][_modelId];

        }
    }

    public override void ChangeFaceModelMaterialColor(int modelId, int colorId)
    {
        if (PlayerPrefs.GetInt("Gender") == 1)
        {
            _maleAccessorysModels[modelId].MeshRenderer.material = _assetSo._Materials[0][colorId];
            _characterSo._characterAccessoryPartDatas[modelId].Material = _assetSo._Materials[0][colorId];
        }
        else if (PlayerPrefs.GetInt("Gender") == 2)
        {
            _femaleAccessorysModels[modelId].MeshRenderer.material = _femaleAssetSo._Materials[0][colorId];
            _characterSo._characterAccessoryPartDatas[modelId].Material = _femaleAssetSo._Materials[0][colorId];
        }

    }

    public override void ChangeAccessoryMaterialColor(int modelId, int colorId)
    {
        if (PlayerPrefs.GetInt("Gender") == 1)
        {
            _maleAccessorysModels[modelId].MeshRenderer.material = _assetSo._Materials[_skinId][colorId];
            _characterSo._characterAccessoryPartDatas[modelId].Material = _assetSo._Materials[_skinId][colorId];
        }
        else if (PlayerPrefs.GetInt("Gender") == 2)
        {
            _femaleAccessorysModels[modelId].MeshRenderer.material = _femaleAssetSo._Materials[_skinId][colorId];
            _characterSo._characterAccessoryPartDatas[modelId].Material = _femaleAssetSo._Materials[_skinId][colorId];
        }

    }

    public override void ChangeBodyMaterialColor(int modelId, int colorId)
    {
        if (PlayerPrefs.GetInt("Gender") == 1)
        {
            _maleBodyModels[modelId].SkinnedMeshRenderer.material = _assetSo._Materials[_skinId][colorId];
            _characterSo._characterBodyPartDatas[modelId].Material = _assetSo._Materials[_skinId][colorId];
        }
        else if (PlayerPrefs.GetInt("Gender") == 2)
        {
            _femaleBodyModels[modelId].SkinnedMeshRenderer.material = _femaleAssetSo._Materials[_skinId][colorId];
            _characterSo._characterBodyPartDatas[modelId].Material = _femaleAssetSo._Materials[_skinId][colorId];
        }
    }

    public override void ChangeSkinColor(int modelId, int colorId)
    {
        //En başta ki SkinColor panelinde karakterin Ten rengini alıyoruz
        //Burada aldığımız Skin ıd ile diğer cretor aşamalarında buradan gelen skin ıd göre material ataması sağlıyoruz
        if (PlayerPrefs.GetInt("Gender") == 1)
        {
            foreach (var item in _maleBodyModels)
            {
                item.SkinnedMeshRenderer.material = _assetSo._Materials[modelId][colorId];
            }

            foreach (var item in _characterSo._characterBodyPartDatas)
            {
                item.Value.Material=_assetSo._Materials[modelId][colorId];
            }
        }
        else if (PlayerPrefs.GetInt("Gender") == 2)
        {
            foreach (var item in _femaleBodyModels)
            {
                item.SkinnedMeshRenderer.material = _femaleAssetSo._Materials[modelId][colorId];
            }
            foreach (var item in _characterSo._characterBodyPartDatas)
            {
                item.Value.Material=_femaleAssetSo._Materials[modelId][colorId];
            }
        }
        _skinId = modelId;
    }
}