﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lightweight.Dependency.Injection
{
    internal sealed class DependencyImplementation
    {
        public DependencyImplementation(Func<object> containedObject, Type objectType, DependencyLifetime dependencyScope)
        {
            ContainedObject = containedObject;
            ObjectType = objectType;
            DependencyScope = dependencyScope;
        }

        public Func<object> ContainedObject { get; }
        public Type ObjectType { get; }
        public DependencyLifetime DependencyScope { get; }
    }
}
