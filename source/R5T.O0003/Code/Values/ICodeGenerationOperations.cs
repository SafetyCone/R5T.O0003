using System;

using R5T.T0131;
using R5T.T0161;
using R5T.T0193;


namespace R5T.O0003
{
    [ValuesMarker]
    public partial interface ICodeGenerationOperations : IValuesMarker
    {
        /// <inheritdoc cref="ICodeGenerationOperator.Generate_Program(INamespaceName)"/>
        public Func<ICode> Generate_Program(
            INamespaceName namespaceName)
        {
            return () => Instances.CodeGenerationOperator.Generate_Program(namespaceName);
        }
    }
}
