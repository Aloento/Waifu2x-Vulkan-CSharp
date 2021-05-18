namespace Waifu2x_Vulkan_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Waifu2xWrapper waifu2x = new();
            waifu2x.setInput("origin.jpg");
            waifu2x.setNoise(2);
            waifu2x.setScale(2);
            waifu2x.setOutput("output.png");
            waifu2x.execute();
            waifu2x.Dispose();
        }
    }
}
