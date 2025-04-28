using UnityEngine;
 public enum PlayerState
{
    none,
    normal,
    inKnockback,
    inStunned,
    onBurn
}

public class Player : BaseEntity
{
    private PlayerState playerState = PlayerState.normal;
    public Player(string _entityName) : base(_entityName, EntityType.Player)
    { }

    public void SetPlayerState(PlayerState _playerState)
    {
        playerState = _playerState;
    }

    public void ShowPlayerStats()
    {
        Debug.Log($"El {EntityName} tiene {Hp} de vida y está en el estado de {playerState}");
    }
}
