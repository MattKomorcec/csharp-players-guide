namespace Chapter22To25OOP
{
    interface ITank
    {
        string Name { get; }

        void Shoot();
        void Move();
        void Aim();
    }
}
