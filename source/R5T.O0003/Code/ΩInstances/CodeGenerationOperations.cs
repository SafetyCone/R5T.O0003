using System;


namespace R5T.O0003
{
    public class CodeGenerationOperations : ICodeGenerationOperations
    {
        #region Infrastructure

        public static ICodeGenerationOperations Instance { get; } = new CodeGenerationOperations();


        private CodeGenerationOperations()
        {
        }

        #endregion
    }
}
