using System;

namespace Qw1nt.LeoEcsLite.EaseAnimation.Runtime.Core.Common
{
    public class HashedEcsAnimation
    {
        public HashedEcsAnimation(int animationHash, EcsAnimation animation)
        {
            Name = animation.Name;
            Hash = animationHash;
            Priority = animation.Priority;
            TransitionDuration = animation.TransitionDuration;
            ClipDuration = animation.AnimationClip.length;
            LayerWeight = animation.LayerWeight;
        }

        public string Name { get; }

        public int Hash { get; }

        public int Priority { get; }

        public float TransitionDuration { get; }

        public float ClipDuration { get; }

        public float LayerWeight { get; }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;

            return obj.GetType() == GetType()
                   && Equals((HashedEcsAnimation) obj);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Hash, TransitionDuration);
        }

        public static bool operator ==(HashedEcsAnimation left, HashedEcsAnimation right)
        {
            return left?.Hash == right?.Hash;
        }

        public static bool operator !=(HashedEcsAnimation left, HashedEcsAnimation right)
        {
            return left?.Hash != right?.Hash;
        }

        public static bool operator >(HashedEcsAnimation left, HashedEcsAnimation right)
        {
            if (left == null)
                return false;

            if (right == null)
                return true;

            return left.Priority > right.Priority;
        }

        public static bool operator <(HashedEcsAnimation left, HashedEcsAnimation right)
        {
            if (left == null)
                return true;

            if (right == null)
                return false;

            return left.Priority < right.Priority;
        }
    }
}