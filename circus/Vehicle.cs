using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circus
{
    public interface IVehicle
    {
        Guid Id { get; set; }

        string Name { get; set; }

        Direction MovementDirection { get; set; }
        
        short Speed { get; set; }

        void Stop();

        void BeginMovement(short speed);

        void ChangeMovementDirection(Direction newDirection);
    }
}
