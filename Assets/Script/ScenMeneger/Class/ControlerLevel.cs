using UnityEngine;

public class ControlerLevel 
{
    public const string NameTagEnemys = "Enemys";
    public const string NameTagHiro = "Hiro";
    public const string NameTagArea = "Area";
   
    static Vector3 centerLevel = new Vector3(0, 0.11f, 0);
    static float radiusLevel = 6;
    
    public static Vector3 RandomLevelPosition()
    {
        Vector3 target = centerLevel + (Vector3)(radiusLevel * Random.insideUnitCircle);
        target=new Vector3(target.y,centerLevel.y,target.z);
        return target;
    }

}
