using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "CharacterList")]
public class CharactersSO : ScriptableObject
{
    
    private static CharactersSO intance;
    
    public static CharactersSO GetInstance()
    {
        if (intance == null)
        {
            intance = new CharactersSO();
        }
        return intance;
    }
    
    
    //Oluşturulan Karakterleri tutmak için bir liste oluşturduk.
    public List<CharacterSO> _Characters;
}
