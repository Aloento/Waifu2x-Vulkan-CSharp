using CppSharp;
using CppSharp.AST;
using CppSharp.Generators;
using CppSharp.Passes;
using Waifu2x;

namespace Waifu2x_Vulkan_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleDriver.Run(new Cpp());
            Waifu2xWrapper waifu = new();
            waifu.Dispose();
        }
    }

    class Cpp : ILibrary
    {
        public override void Postprocess(Driver driver, ASTContext ctx)
        {
        }

        public override void Preprocess(Driver driver, ASTContext ctx)
        {
        }

        public override void Setup(Driver driver)
        {
            var options = driver.Options;
            options.GeneratorKind = GeneratorKind.CSharp;
            var module = options.AddModule("Waifu2x");
            module.IncludeDirs.Add(@"C:\Codes\C\Waifu2x-Vulkan-Library\src");
            module.Headers.Add("wrapper.h");
            module.LibraryDirs.Add(@"C:\Codes\C#\Waifu2x-Vulkan-CSharp");
            module.Libraries.Add("Waifu2x-Vulkan-Library.dll");
        }

        public override void SetupPasses(Driver driver)
        {
            driver.Context.TranslationUnitPasses.RenameDeclsUpperCase(RenameTargets.Any);
            driver.Context.TranslationUnitPasses.AddPass(new FunctionToInstanceMethodPass());
        }
    }
}
