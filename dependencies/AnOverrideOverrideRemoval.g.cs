using Elements;
using System.Collections.Generic;
using System;
using System.Linq;

namespace HideOverride
{
	/// <summary>
	/// Override metadata for AnOverrideOverrideRemoval
	/// </summary>
	public partial class AnOverrideOverrideRemoval : IOverride
	{
        public static string Name = "An Override Removal";
        public static string Dependency = null;
        public static string Context = "[*discriminator=Elements.OtherBox]";
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