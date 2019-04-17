namespace Chapter22To25OOP
{
    class DerivedClassExample : BaseClassExample
    {
        public DerivedClassExample()
        {
            SomeProp = 34;
        }

        public override string SomeMethod()
        {
            return "This is cool!";
        }
    }
}
