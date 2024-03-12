using Elements;
using System.Collections.Generic;
using System;
using System.Linq;

namespace HideOverride
{
	/// <summary>
	/// Override metadata for HidableOverrideOverrideRemoval
	/// </summary>
	public partial class HidableOverrideOverrideRemoval : IOverride
	{
        public static string Name = "Hidable Override Removal";
        public static string Dependency = null;
        public static string Context = "[*discriminator=Elements.Box]";
		public static string Paradigm = "Edit";

        /// <summary>
        /// Get the override name for this override.
        /// </summary>
        public string GetName() {
			return Name;
		}

		public object GetIdentity() {

			return Identity;
		}

	}

}