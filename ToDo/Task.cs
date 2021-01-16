using System.Collections.Generic;
using ToDo.Enums;
using ToDo.Tags;

// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Local
#pragma warning disable 169

namespace ToDo
{
    internal abstract class Task
    {
        private string Summary;

        private bool? Urgent;
        private bool? Important;
        private Scope? Scope;
        private Context Context;

        protected Status Status = Status.Inbox;

        private string Description;

        private Needs? Needs;
        private List<Goal> Goals;

        private List<Task> Subtasks;
    }
}
