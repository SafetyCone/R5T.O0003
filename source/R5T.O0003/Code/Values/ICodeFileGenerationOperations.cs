using System;
using System.Threading.Tasks;

using R5T.F0124;
using R5T.T0131;
using R5T.T0161;
using R5T.T0172;


namespace R5T.O0003
{
    [ValuesMarker]
    public partial interface ICodeFileGenerationOperations : IValuesMarker
    {
        /// <inheritdoc cref="ICodeGenerationOperations.Generate_Program(INamespaceName)"/>
        public bool Write_ProgramFile_Synchronous(
            ICodeFilePath codefilePath,
            INamespaceName namespaceName,
            FileExistsBehavior fileExistsBehavior = IFileExistsBehaviors.Default)
        {
            return Instances.CodeFileOperator.Write_Code_Synchronous(
                codefilePath,
                Instances.CodeGenerationOperations.Generate_Program(namespaceName),
                fileExistsBehavior);
        }


        // Create class1 file.


        // Create interface1 file.
    }
}
