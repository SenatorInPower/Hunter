using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;
using Sirenix.Serialization;

public class SpawnHiro : SerializedMonoBehaviour
{
    struct Stats
    {
        int HP;
        int Demage;
        int Energy;
        Transform PosSpawner;
    }
    
    [Button]
   
    void SpawnerHiro(Stats stats)
    {
        HiroControl Hiro = new HiroControl();
        
    }
}
