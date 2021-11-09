using UnityEngine;

namespace Commands
{
    public abstract class Command
    {
        public abstract void Execute(Player player);
    }

    public class JumpCommand : Command
    {
        public override void Execute(Player player)
        {
           player.Jump();
        }
    }

    public class AttackCommand : Command
    {
        public override void Execute(Player player)
        {
            player.Attack();
        }
    }

    public class MoveLeftCommand : Command
    {
        public override void Execute(Player player)
        {
            player.MoveLeft();
        }
    }

    public class MoveRightCommand : Command
    {
        public override void Execute(Player player)
        {
            player.MoveRight();
        }
    }
}
