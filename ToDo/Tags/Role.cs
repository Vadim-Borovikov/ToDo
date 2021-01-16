// ReSharper disable InconsistentNaming
// ReSharper disable NotAccessedField.Local

namespace ToDo.Tags
{
    internal class Role : Tag
    {
        private Goal Main;

        private Role(string name, Goal mainGoal) : base(name)
        {
            Main = mainGoal;
        }
    }
}