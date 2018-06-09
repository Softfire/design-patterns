namespace Command
{
    public class Player
    {
        /// <summary>
        /// Command.
        /// </summary>
        private Command Command { get; }

        /// <summary>
        /// Player.
        /// An object with a stored command.
        /// </summary>
        /// <param name="command">A command to store.</param>
        public Player(Command command)
        {
            Command = command;
        }

        /// <summary>
        /// Execute Command.
        /// Execute stored command.
        /// </summary>
        public void ExecuteCommand()
        {
            Command.Execute();
        }
    }
}