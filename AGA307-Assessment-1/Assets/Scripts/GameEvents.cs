using System;

public static class GameEvents
{ 
    public static event Action<EnemyBeh> EnemyHit;
    public static void OneEnemyHit(EnemyBeh e) => EnemyHit?.Invoke(e);

    public static event Action<EnemyBeh> EnemyDie;
    public static void OneEnemyDie(EnemyBeh e) => EnemyDie?.Invoke(e);

}
