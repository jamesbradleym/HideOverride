using System.Drawing;
using Elements.Geometry;
using Elements.Geometry.Solids;
using HideOverride;

namespace Elements
{
    public partial class Box : GeometricElement
    {
        public string AddId { get; set; }

        public Box(HidableOverrideOverrideAddition add)
        {
            this.AddId = add.Id;

            this.Transform = new Transform(add.Value.Point);
            this.GenerateGeometry();
        }

        public Box(string id, Vector3 position)
        {
            this.AddId = id;

            this.Transform = new Transform(position);
        }

        public bool Match(HidableOverrideIdentity identity)
        {
            return identity.AddId == this.AddId;
        }

        public Box Update(HidableOverrideOverride edit)
        {
            this.Transform = new Transform(edit.Value.Transform);
            return this;
        }

        public virtual void GenerateGeometry()
        {
            var random = new Random(21);

            var rep = new Representation();
            var solidRep = new Solid();

            var profile = Polygon.Rectangle(Vector3.Origin, new Vector3(10, 10, 0));

            var extrusion = new Extrude(profile, 10, Vector3.ZAxis, false);

            rep.SolidOperations.Add(extrusion);

            var consol = new ConstructedSolid(solidRep);
            rep.SolidOperations.Add(consol);

            this.Representation = rep;

            this.Material = random.NextMaterial();
        }
    }
}