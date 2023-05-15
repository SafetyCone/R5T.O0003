using System;


namespace R5T.O0003
{
    public static class Instances
    {
        public static F0131.ICodeFileOperator CodeFileOperator => F0131.CodeFileOperator.Instance;
        public static ICodeGenerationOperator CodeGenerationOperator => O0003.CodeGenerationOperator.Instance;
        public static ICodeGenerationOperations CodeGenerationOperations => O0003.CodeGenerationOperations.Instance;
    }
}