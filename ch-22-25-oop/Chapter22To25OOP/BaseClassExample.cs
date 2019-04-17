namespace Chapter22To25OOP
{
    class BaseClassExample
    {
        public int SomeProp { get; set; }

        public BaseClassExample()
        {
            SomeProp = 5;
        }

        public virtual string SomeMethod()
        {
            return "Hello";
        }
    }
}
