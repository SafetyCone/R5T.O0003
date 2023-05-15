using System;


namespace R5T.O0003
{
    public class CodeGenerationOperator : ICodeGenerationOperator
    {
        #region Infrastructure

        public static ICodeGenerationOperator Instance { get; } = new CodeGenerationOperator();


        private CodeGenerationOperator()
        {
        }

        #endregion
    }
}
