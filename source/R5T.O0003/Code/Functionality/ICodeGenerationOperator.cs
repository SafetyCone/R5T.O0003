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
        /// Gets the console application template program code file content.
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
    }
}
