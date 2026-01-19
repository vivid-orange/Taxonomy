// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Text;

namespace CatalogueGenerator.Utilities
{
    public struct UtilityClassProperties
    {
        public string NameSpace;
        public string AccessModifier = "public partial class CatalogueFactory";
        public string Catalogue;
        public List<string> Values;

        public UtilityClassProperties(string nmspc, string catalogue)
        {
            NameSpace = nmspc;
            Catalogue = catalogue;
            Values = new List<string>();
        }

        public void AppendType(string name)
        {
            Values.Add(name);
        }

        public void WriteClassToFile(string filePath)
        {
            var sb = new StringBuilder();

            sb.AppendLine($@"namespace {NameSpace}
{{
    {AccessModifier}
    {{
        public static ICatalogue Create{Catalogue}({Catalogue} {Catalogue.ToLower()})
        {{
            return {Catalogue.ToLower()} switch
            {{");
            foreach (string v in Values)
            {
                sb.AppendLine($"                {Catalogue}.{v} => new {v}(),");
            }

            sb.AppendLine($@"                _ => throw new System.NotImplementedException(),
            }};
        }}
    }}
}}");
            var file = new StreamWriter($"{filePath}/{Catalogue}Factory.cs");
            file.Write(sb);
            file.Close();
        }
    }
}
