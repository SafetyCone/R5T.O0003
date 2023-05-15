using System;


namespace R5T.O0003
{
    public class CodeFileGenerationOperations : ICodeFileGenerationOperations
    {
        #region Infrastructure

        public static ICodeFileGenerationOperations Instance { get; } = new CodeFileGenerationOperations();


        private CodeFileGenerationOperations()
        {
        }

        #endregion
    }
}
