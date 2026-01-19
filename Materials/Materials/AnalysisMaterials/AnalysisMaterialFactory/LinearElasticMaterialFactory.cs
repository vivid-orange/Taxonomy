using VividOrange.Materials.StandardMaterials;
using VividOrange.Materials.StandardMaterials.En;

namespace VividOrange.Materials
{
    public static partial class AnalysisMaterialFactory
    {
        public static ILinearElasticMaterial CreateLinearElastic(IStandardMaterial material)
        {
            switch (material.Standard.Body)
            {
                case Standards.StandardBody.EN:
                    switch (material)
                    {
                        case IEnConcreteMaterial enConcrete:
                            return EnConcreteFactory.CreateLinearElastic(enConcrete.Grade);

                        case IEnRebarMaterial enRebar:
                            return EnRebarFactory.CreateLinearElastic(enRebar.Grade);

                        case IEnSteelMaterial enSteel:
                            return EnSteelFactory.CreateLinearElastic(enSteel);

                        default:
                            throw new ArgumentException($"{material.Type} material type not implemented for Eurocode");
                    }

                default:
                    throw new ArgumentException($"{material.Standard.Body} standard body not implemented");

            }
        }
    }
}
