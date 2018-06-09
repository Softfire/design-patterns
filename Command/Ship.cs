namespace Command
{
    class Ship : Command
    {
        /// <summary>
        /// Ship.
        /// Stores a laser cannon to be fired at a later date.
        /// </summary>
        /// <param name="laserCannon">A laser cannon. To be fired at a later date.</param>
        public Ship(LaserCannon laserCannon) : base(laserCannon)
        {

        }

        /// <summary>
        /// Execute.
        /// Executes the stored command.
        /// In this case it fires a laser.
        /// </summary>
        public override void Execute()
        {
            LaserCannon.Fire();
        }
    }
}