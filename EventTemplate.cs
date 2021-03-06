using System.Collections.Generic;
using Invert.Core.GraphDesigner;
using UnityEngine;

namespace Invert.uFrame.ECS.Templates
{
    [RequiresNamespace("uFrame.ECS")]
    [RequiresNamespace("UniRx")]
    [NamespacesFromItems]
    public partial class EventTemplate
    {
        [ForEach("Properties"), GenerateProperty,WithName, WithField(null, typeof(SerializeField))]
        public _ITEMTYPE_ Property { get; set; }

        [ForEach("Collections"), GenerateProperty, WithName, WithLazyField]
        public List<_ITEMTYPE_> Collection { get; set; }
    }
}