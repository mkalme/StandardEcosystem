using System;

namespace SimpleBinaryTag {
    public sealed class AnyTypeArrayTag : Tag {
        public Tag[] InternalArray { get; private set; }
        public int Length => InternalArray.Length;

        public static implicit operator AnyTypeArrayTag(Tag[] array) => new AnyTypeArrayTag(array);
        public static implicit operator Tag[](AnyTypeArrayTag array) => array.InternalArray;

        public AnyTypeArrayTag() : base(TagID.AnyTypeArray) {}
        public AnyTypeArrayTag(Tag[] array) : base(TagID.AnyTypeArray) { 
            InternalArray = array;
        }

        public override Tag Clone() {
            Tag[] array = new Tag[Length];

            for (int i = 0; i < Length; i++) {
                array[i] = (ObjectTag)array[i].Clone();
            }

            return new AnyTypeArrayTag(array);
        }
        public override bool Equals(Tag other) {
            if (other.ID != ID) return false;

            Tag[] otherArray = (other as AnyTypeArrayTag).InternalArray;

            if (InternalArray.Length != otherArray.Length) return false;
            for (int i = 0; i < InternalArray.Length; i++) {
                if (!InternalArray[i].Equals(otherArray[i])) return false;
            }

            return true;
        }
    }
}
