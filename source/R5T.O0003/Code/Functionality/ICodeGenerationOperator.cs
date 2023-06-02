using System;

using R5T.F0131.Extensions;
using R5T.T0132;
using R5T.T0161;
using R5T.T0193;


namespace R5T.O0003
{
    [FunctionalityMarker]
    public partial interface ICodeGenerationOperator : IFunctionalityMarker
    {
        /// <summary>
        /// Gets the console application template program class content.
        /// </summary>
        /// <remarks>
        /// Does not contain a using directive for the "System" namespace.
        /// Uses an internal access modifier for the program class (which makes sense because)
        /// </remarks>
        public ICodeFileContent Generate_Program(
            INamespaceName namespaceName)
        {
            var output =
$@"
namespace ConsoleApp
{{
    internal class Program
    {{
        static void Main(string[] args)
        {{
            Console.WriteLine(""Hello, World!"");
        }}
    }}
}}
".ToCodeFileContent();

            return output;
        }

        /// <summary>
        /// Gets the console application template program file content.
        /// </summary>
        /// <remarks>
        /// Contains a using directive for the "System" namespace.
        /// </remarks>
        public ICodeFileContent Generate_ProgramFileContent(
            INamespaceName namespaceName)
        {
            var programClassContent = this.Generate_Program(namespaceName);

            var output =
$@"
using System;


{programClassContent}
"
// Preserve the ending blank line.
.ToCodeFileContent_WithoutTrimEnd();

            return output;
        }
    }
}
