using UnityEngine;

public class ControlerLevel 
{
    public const string NameTagEnemys = "Enemys";
    public const string NameTagHiro = "Hiro";
    public const string NameTagArea = "Hiro";

    static Vector3 centerLevel;
    static float radiusLevel = 10;
    public static Vector3 RandomLevelPosition()
    {
        Vector3 target = centerLevel + (Vector3)(radiusLevel * Random.insideUnitCircle);
        return target;
    }

}
