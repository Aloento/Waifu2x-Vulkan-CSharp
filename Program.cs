using System;

namespace Waifu2x_Vulkan_CSharp
{
    internal class Program
    {
        private static void Main()
        {
            Waifu2xWrapper waifu2X = new();
            waifu2X.setInput("origin.jpg");
            waifu2X.setNoise(2);
            waifu2X.setScale(2);
            waifu2X.setOutput("output.png");
            Console.WriteLine(waifu2X.execute() == 0 ? "Successful" : "Failed");
            waifu2X.Dispose();
        }
    }
}
