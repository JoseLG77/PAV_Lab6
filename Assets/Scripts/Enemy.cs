using UnityEngine;

public enum EnemyType
{
    none,
    Skeleton,
    Golem,
    Dragon
}
public interface ISpecialAttack
{
    public float GetCritDamage();
    public void SpecialEffect();
}

public class Enemy : BaseEntity, ISpecialAttack
{
    private EnemyType type = EnemyType.none;
    private int baseDamage;
    private int critRate;

    public int BaseDamage => baseDamage;
    public int CritRate => critRate;
    public EnemyType Type => type;

    public Enemy(string _entityName, EnemyType _type, int _baseDamage, int _critRate) : base(_entityName, EntityType.Enemy)
    {
        type = _type;
        baseDamage = _baseDamage;
        critRate = _critRate;
    }
    public float GetCritDamage()
    {
        return Random.Range(0, 101) <= CritRate ? BaseDamage * 2 : BaseDamage;
    }
    public virtual void SpecialEffect()
    {
        Debug.Log("Default attack");
    }
}
public class Skeleton : Enemy
{
    public Skeleton(string _entityName) : base(_entityName, EnemyType.Skeleton, 5, 10)
    { }

    public override void SpecialEffect()
    {
        Debug.Log("El esqueleto aplicó el efecto de KnockBack al jugador");
    }
}
public class Golem : Enemy
{
    public Golem(string _entityName) : base(_entityName, EnemyType.Golem, 10, 20)
    { }
    public override void SpecialEffect()
    {
        Debug.Log("El Golem aplicó el efecto de Stunned al jugador");
    }
}
public class Dragon : Enemy
{
    public Dragon(string _entityName) : base(_entityName, EnemyType.Dragon, 20, 40)
    { }
    public override void SpecialEffect()
    {
        Debug.Log("El esqueleto aplicó el efecto de Burn al jugador");
    }
}