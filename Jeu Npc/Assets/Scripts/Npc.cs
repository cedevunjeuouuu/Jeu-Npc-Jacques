using System;
using UnityEngine;

namespace oop
{
    public abstract class Npc : AbstractEntity
    {
        protected override void LifeModified()
        {
            base.LifeModified();
            
            // TODO UPDATE LIFE DISPLAY IN CANVAS
        }

        private void Update()
        {
            UpdateBehavior();
            UpdateMovement();
        }

        public virtual void UpdateBehavior()
        {
            
        }
        
        protected virtual void UpdateMovement()
        {
            
        }
        
        protected override void CollisionCollectible(Collectible collectible)
        {
            base.CollisionCollectible(collectible);
            Debug.Log("npc collision collectible");
        }
    }
}
