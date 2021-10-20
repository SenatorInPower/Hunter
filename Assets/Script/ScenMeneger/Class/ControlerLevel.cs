using UnityEngine;

public class ControlerLevel 
{
    public const string NameTagEnemys = "Enemys";
    public const string NameTagHiro = "Player";
    public const string NameTagArea = "Area";
   
    static Vector3 centerLevel = new Vector3(0, 0.11f, 0);
    static float radiusLevel = 6;
    
    public static Vector3 RandomLevelPosition(Vector3 posGameObject)
    {
        Vector3 target = Vector3.zero + (Vector3)(4 * Random.insideUnitCircle);
        target = new Vector3(target.y, posGameObject.y, target.x);
        //  target.z = posGameObject.z;
        return target;
    }

}
