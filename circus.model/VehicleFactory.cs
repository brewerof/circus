using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circus.model
{
    public static class VehicleFactory
    {

        public static IVehicle Create(string name)
        {
            Vehicle vehicle = new Vehicle(name);
            return vehicle;
        }

        class Vehicle : IVehicle
        {
            public Vehicle(string name)
            {
                Id = Guid.NewGuid();
                Name = name;
            }
            public Guid Id { get; private set; }
            public string Name { get; private set; }
            public Direction MovementDirection { get; set; }
            public short Speed { get; set; }
            public void Stop()
            {
                Speed = 0;
            }

            public void BeginMovement(short speed)
            {
                Speed = speed;
            }

            public void ChangeMovementDirection(Direction newDirection)
            {
                MovementDirection = newDirection;
            }
        }
    }
}
