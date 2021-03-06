﻿#pragma warning disable CS0626 // Method, operator, or accessor is marked external and has no attributes on it
#pragma warning disable CS0649 // Field is never assigned to, and will always have its default value
#pragma warning disable CS0169 // The field is never used

using System.Collections.Generic;

namespace Monocle {
    // No public constructors.
    class patch_EntityList {

        // We're effectively in EntityList, but still need to "expose" private fields to our mod.
        private List<Entity> toAdd;
        public List<Entity> ToAdd => toAdd;

    }
    public static class EntityListExt {

        // Mods can't access patch_ classes directly.
        // We thus expose any new members through extensions.

        /// <summary>
        /// Get the list of entities which are about to get added.
        /// </summary>
        public static List<Entity> GetToAdd(this EntityList self)
            => ((patch_EntityList) (object) self).ToAdd;

    }
}
