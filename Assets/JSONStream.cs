
using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class JSONStream : MonoBehaviour
{
    public TextAsset jsonFile;

    [System.Serializable]
    public class Weapon
    {
        public string type;
    }

    [System.Serializable]
    public class WeaponList
    {
        public Weapon[] weapon;
    }


    public WeaponList weaponsInJSON = new WeaponList();
    

    void Start()
    {
        
         weaponsInJSON = JsonUtility.FromJson<WeaponList>(jsonFile.text);

        
    }

    
}
