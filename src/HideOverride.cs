using Elements;
using Elements.Geometry;
using System.Collections.Generic;

namespace HideOverride
{
    public static class HideOverride
    {
        /// <summary>
        /// The HideOverride function.
        /// </summary>
        /// <param name="model">The input model.</param>
        /// <param name="input">The arguments to the execution.</param>
        /// <returns>A HideOverrideOutputs instance containing computed results and the model with any new elements.</returns>
        public static HideOverrideOutputs Execute(Dictionary<string, Model> inputModels, HideOverrideInputs input)
        {
            // Your code here.
            var output = new HideOverrideOutputs();

            var boxes = input.Overrides.HidableOverride.CreateElements(
              input.Overrides.Additions.HidableOverride,
              input.Overrides.Removals.HidableOverride,
              (add) => new Elements.Box(add),
              (box, identity) => box.Match(identity),
              (box, edit) => box.Update(edit)
            );

            output.Model.AddElements(boxes);
            return output;
        }
    }
}