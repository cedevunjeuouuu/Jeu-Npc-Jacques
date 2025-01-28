using System;
using UnityEngine;

namespace oop
{
    public abstract class AbstractEntity : MonoBehaviour
    {
        protected int hp { get; private set; }

        public void ApplyHit(int hitValue)
        {
            hp -= hitValue;
            hp = Mathf.Clamp(hp, 0, 100);
            
            if (hp <= 0)
            {
                Die();
            }
            
            LifeModified();
        }

        protected virtual void LifeModified()
        {
            
        }

        protected virtual void Die()
        {
            Destroy(gameObject);
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            var collectible = other.GetComponent<Collectible>();
            
            if (collectible != null)
            {
                CollisionCollectible(collectible);
            }
            
            var npc = other.GetComponent<Npc>();
            
            if (npc != null)
            {
                CollisionNpc(npc);
            }
        }

        protected virtual void CollisionCollectible(Collectible collectible)
        {
            Debug.Log($"collision with collectible {collectible.name}");
        }
        
        protected virtual void CollisionNpc(Npc npc)
        {
            Debug.Log($"collision with npc {npc.name}");
        }
        
    }
}