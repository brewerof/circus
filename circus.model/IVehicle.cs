using System;

namespace circus.model
{
    public interface IVehicle
    {
        Guid Id { get; }

        string Name { get; }

        Direction MovementDirection { get; set; }
        
        short Speed { get; set; }

        void Stop();

        void BeginMovement(short speed);

        void ChangeMovementDirection(Direction newDirection);
    }
}
