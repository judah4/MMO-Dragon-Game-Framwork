using MessagePack;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mmogf
{
    [MessagePackObject]
    public struct Health : IEntityComponent
    {
        public const int ComponentId = 1002;
        public int GetComponentId()
        {
            return ComponentId;
        }

        [Key(0)]
        public int Current { get; set; }
        [Key(1)]
        public int Max { get; set; }

        #region Commands

        [MessagePackObject]
        public struct TakeDamageCommand : ICommand
        {
            public const int CommandId = 10002;
            public int GetCommandId() => CommandId;

            [Key(0)]
            public int Amount { get; set; }
        }

        #endregion

    }
}
