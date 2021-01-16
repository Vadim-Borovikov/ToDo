// ReSharper disable NotAccessedField.Local
// ReSharper disable InconsistentNaming

namespace ToDo.Tags
{
    internal abstract class Tag
    {
        private string Name;

        protected Tag(string name) { Name = name; }
    }
}