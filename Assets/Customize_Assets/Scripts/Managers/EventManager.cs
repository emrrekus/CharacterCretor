using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public enum GameEvent
{
    OnChangeFaceModel,
    OnChangeAccessoryModel,
    OnChangeBodyModel,
    OnChangeSkinColor,
    OnChangeAccessoryMaterial,
    OnChangeFaceModelMaterial,
    OnChangeBodyModelMaterial,
   
}


namespace CharacterCretor.Managers
{
    public class EventManager : MonoBehaviour
    {
        
        
        private static Dictionary<GameEvent, Action<int,int>> eventTable = new Dictionary<GameEvent, Action<int,int>>();
        
        //Oluşturduğumuz dictionary içerisinde ki evente fonksiyon ekleme methodu
        public static void AddHandler(GameEvent gameEvent, Action<int,int> action)
        {
            if (!eventTable.ContainsKey(gameEvent)) eventTable[gameEvent] = action;
            else eventTable[gameEvent] += action;
        }
        //Oluşturduğumuz dictionary içerisinde ki evente fonksiyon çıkarma methodu
        public static void RemoveHandler(GameEvent gameEvent, Action<int,int> action)
        {
            if (eventTable[gameEvent] != null) eventTable[gameEvent] -= action;
            if (eventTable[gameEvent] == null) eventTable.Remove(gameEvent);
        }
        //Oluşturduğumuz dictionary içerisinde ki çağırlan eventi tetikleme methodu
        public static void StartMethod(GameEvent gameEvent, int modelId,int colorId)
        {
            eventTable[gameEvent]?.Invoke(modelId,colorId);
        }
    }
}