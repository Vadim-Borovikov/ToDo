// ReSharper disable InconsistentNaming
// ReSharper disable NotAccessedField.Local

namespace ToDo.Tags
{
    internal class Goal : Tag
    {
        private Task Next;
        private Role Role;

        private Goal(string name, Task nextAction, Role role) : base(name)
        {
            Next = nextAction;
            Role = role;
        }
    }
}