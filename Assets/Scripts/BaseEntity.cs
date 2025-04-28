using UnityEngine;

#region Enums

public enum EntityType
{
    none,
    Player,
    Enemy
}

#endregion

#region Interfaces

public interface IMovement
{
    public void Move();
}

public interface IDamageable
{
    public void ApplyDamage(float _damage);
    public bool CheckIfAlive();
}
#endregion

public class BaseEntity : MonoBehaviour, IDamageable, IMovement
{
    #region Atributes

    private string entityName;
    private int hp = 100;
    private EntityType type = EntityType.none;
    private bool isAlive = true;

    #endregion

    #region Constructor

    public BaseEntity(string _entityName, EntityType _type)
    { }

    #endregion

    #region Getters y Setters

    public string EntityName => entityName;
    public int Hp => hp;

    public void SetHp(int _hp)
    {
        hp = _hp;
    }

    #endregion

    #region Metodos

    public void ApplyDamage(float _damage)
    {
        _damage = Mathf.Abs(_damage);
        hp = (hp - _damage) <= 0 ? 0 : hp - (int)_damage;
    }

    public bool CheckIfAlive()
    {
        return isAlive;
    }

    public void Move()
    {
        Debug.Log($"{entityName} se está moviendo");
    }
    #endregion
}
