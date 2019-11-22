namespace GeometricObjects
{
    class Demo1
    {
        public int Value = 1;
    }

    class Demo2
    {
        public void ChangeValue(Demo1 @object)
        {
            @object = new Demo1();      // umgebogen
            @object.Value = 2;
        }
        public void ChangeValue(ref Demo1 @object)
        {
            @object = new Demo1();      // umgebogen
            @object.Value = 2;
        }
    }
}
