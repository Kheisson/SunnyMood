using UnityEngine;

namespace DefaultNamespace
{
    public class PlayerAnimations
    {
        private readonly Animator _animator;
        private readonly int isWalkingHash;
        private readonly int isJumpingHash;
        
        public PlayerAnimations(Animator animator)
        {
            _animator = animator;
            isJumpingHash = Animator.StringToHash("isJumping");
            isWalkingHash = Animator.StringToHash("isWalking");
        }
        
        public void SetIsWalking(bool isWalking)
        {
            if(!ValidateChange(_animator.GetBool(isWalkingHash), isWalking)
               || _animator.GetBool(isJumpingHash)) return;
            
            _animator.SetBool(isWalkingHash, isWalking);
        }
        
        public void SetIsJumping(bool isJumping)
        {
            if(!ValidateChange(_animator.GetBool(isJumpingHash), isJumping)) return;
            
            _animator.SetBool(isWalkingHash, false);
            _animator.SetBool(isJumpingHash, isJumping);
        }

        private bool ValidateChange(bool origin, bool target)
        {
            return origin != target;
        }

    }
}