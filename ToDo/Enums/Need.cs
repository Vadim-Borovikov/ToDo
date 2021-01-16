using System;

namespace ToDo.Enums
{
    [Flags]
    internal enum Needs : byte
    {
        /// <summary>
        /// to Live
        /// </summary>
        Physical = 0,

        /// <summary>
        /// to Love
        /// </summary>
        Social = 1,

        /// <summary>
        /// to Learn
        /// </summary>
        Mental = 2,

        /// <summary>
        /// to Leave a Legacy
        /// </summary>
        Spiritual = 4
    }
}