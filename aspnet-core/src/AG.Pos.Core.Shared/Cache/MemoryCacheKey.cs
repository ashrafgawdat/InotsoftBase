using System;
using System.Collections.Generic;

namespace AG.Pos.Cache
{
    public class MemoryCacheKey<TKey, TOwner> : IEquatable<MemoryCacheKey<TKey, TOwner>>
    {
        private static readonly IEqualityComparer<TKey> StaticComparer = EqualityComparer<TKey>.Default;

        public MemoryCacheKey(TKey key)
        {
            Key = key;
        }

        public TKey Key { get; }

        protected virtual IEqualityComparer<TKey> Comparer => StaticComparer;

        public bool Equals(MemoryCacheKey<TKey, TOwner> other)
        {
            if (other == null) return false;
            if (other.GetType() != GetType()) return false;
            return Comparer.Equals(Key, other.Key);
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as MemoryCacheKey<TKey, TOwner>);
        }

        public override int GetHashCode()
        {
            return Comparer.GetHashCode(Key);
        }

        public override string ToString()
        {
            return Key?.ToString() ?? "";
        }
    }
}
