namespace GenericClass
{
    class Nullable<T> where T : struct
    {
        public object Value { get; }

        public Nullable()
        {
        }

        public Nullable(T a)
        {
            this.Value = a;
        }

        public bool IsNull()
        {
            return Value == null ? true : false;
        }

        public T ValueOfObj()
        {
            if (this.IsNull() == false)
                return (T) Value;

            return (T) default;
        }
    }
}