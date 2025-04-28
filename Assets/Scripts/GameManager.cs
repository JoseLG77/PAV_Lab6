using UnityEngine;

public class GameManager : MonoBehaviour
{
    private Player Player1 = new Player("Player1");
    private Skeleton Skeleton1 = new Skeleton("Skeleton1");
    private Golem Golem1 = new Golem("Golem1");
    private Dragon Dragon1 = new Dragon("Dragon1");

    void Start()
    {
        Player1.Move();
        SkeletonAttack();
        GolemAttack();
        DragonAttack();
    }

    private void SkeletonAttack()
    {
        Player1.ApplyDamage(Skeleton1.GetCritDamage());
        Skeleton1.SpecialEffect();
        Player1.SetPlayerState(PlayerState.inKnockback);
        Player1.ShowPlayerStats();
    }
    private void GolemAttack()
    {
        Player1.ApplyDamage(Golem1.GetCritDamage());
        Golem1.SpecialEffect();
        Player1.SetPlayerState(PlayerState.inStunned);
        Player1.ShowPlayerStats();
    }
    private void DragonAttack()
    {
        Player1.ApplyDamage(Dragon1.GetCritDamage());
        Dragon1.SpecialEffect();
        Player1.SetPlayerState(PlayerState.onBurn);
        Player1.ShowPlayerStats();
    }
}
