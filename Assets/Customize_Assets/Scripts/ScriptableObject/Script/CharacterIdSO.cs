using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "CharacterId")]
public class CharacterIdSO : ScriptableObject
{
   private static CharacterIdSO intance;
    
   public static CharacterIdSO GetInstance()
   {
      if (intance == null)
      {
         intance = new CharacterIdSO();
      }
      return intance;
   }
   public int _characterId;
}
