namespace Command
{
    public abstract class Command
    {
        /// <summary>
        /// Laser Cannon.
        /// An object waiting to be actioned.
        /// </summary>
        protected LaserCannon LaserCannon { get; }
        
        /// <summary>
        /// Command.
        /// An object to be actioned at a later date.
        /// </summary>
        /// <param name="laserCannon">A laser cannon. To be fired at a later date.</param>
        public Command(LaserCannon laserCannon)
        {
            LaserCannon = laserCannon;
        }

        /// <summary>
        /// Execute.
        /// Executes the stored command.
        /// </summary>
        public abstract void Execute();
    }
}