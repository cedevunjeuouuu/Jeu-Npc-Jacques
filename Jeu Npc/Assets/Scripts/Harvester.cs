using System;
using System.Collections.Generic;
using UnityEngine;

namespace oop
{
    public class Harvester : Npc
    {
        private enum HarvestState
        {
            search,
            harvest,
            back
        }

        private HarvestState currentState = HarvestState.search;
        private Vector3 m_target;
        private List<Collectible> collect = new List<Collectible>();
        public override void UpdateBehavior()
        {
        
            switch (currentState)
            {
                case HarvestState.search: Search(); // DEFINE MOVEMENT TO NEAREST COLLECTIBLE
                    break;
                case HarvestState.harvest: // DEFINE MOVEMENT TO LOCKED
                    break;
                case HarvestState.back: // DEFINE MOVEMENT TO L'ENTREPOT
                    break;
            }
        }

        private void Start()
        {
        
            foreach (Collectible col in collect)
            {
                
            }
        }

        private void Search()
        {
            Vector3 nearest = new Vector3();
            // GO THROUGH ALL COLLECTIBLE AND CHECK VECTOR3.DISTANCE TO GET NEAREST
            m_target = nearest;
        }

        protected override void UpdateMovement()
        {
            // can't move during harvest
            if (currentState == HarvestState.harvest)
            {
                return;
            }
            
            base.UpdateMovement();
            if (m_target.x - transform.position.x < 0)
            {
                transform.position += new Vector3(-0.01f, 0, 0);
            }
            else if (m_target.x - transform.position.x > 0)
            {
                transform.position += new Vector3(+0.01f, 0, 0);
            }
        }
        
        protected override void CollisionCollectible(Collectible collectible)
        {
            base.CollisionCollectible(collectible);
            collectible.ApplyHit(1000);
        }
    }
}
