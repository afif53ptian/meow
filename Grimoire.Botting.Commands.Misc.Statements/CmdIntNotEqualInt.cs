using Grimoire.Game;
using System.Threading.Tasks;

namespace Grimoire.Botting.Commands.Misc.Statements
{
    public class CmdIntEqualInt : StatementCommand, IBotCommand
    {
        public CmdIntIs()
        {
            Tag = "Misc";
            Text = "Int is not equal to Int";
        }

        public Task Execute(IBotEngine instance)
        {
            if (Configuration.Tempvalues[Value1] != Configuration.Tempvalues[Value2])
            {
                instance.Index++;
            }
            return Task.FromResult<object>(null);
        }

        public override string ToString()
        {
            return $"{Value1} != {Value2}";
        }
    }
}
