using UnityEngine;

[CreateAssetMenu(fileName ="Item", menuName ="Data/Inventory Item", order =0)]
public class HealthPotionSO : ItemSO
{
    public int HealthValue;
    public override void Use(GameObject player)
    {
        LifeController _lifeController = player.GetComponent<LifeController>();

        if (_lifeController == null)
        {
            _lifeController.HP = HealthValue;
        }
    }

}
