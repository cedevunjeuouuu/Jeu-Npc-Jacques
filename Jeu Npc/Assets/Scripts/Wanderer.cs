using UnityEngine;

namespace oop
{
    public class Wanderer : Npc
    {
        [SerializeField] private float speed = 0.1f;
        private bool rightMovement;
        
        protected override void UpdateMovement()
        {
            base.UpdateMovement();
            transform.position += new Vector3(rightMovement ? speed : -speed, 0, 0);
        }

        protected override void CollisionCollectible(Collectible collectible)
        {
            base.CollisionCollectible(collectible);
            rightMovement = !rightMovement;
        }
    }
} 
