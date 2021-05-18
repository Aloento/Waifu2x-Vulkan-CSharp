# Waifu2x-Vulkan-CSharp

Example of using `Waifu2x-Vulkan-Library` in C#  
Ready-to-Use：https://github.com/Aloento/YourWaifu2x/blob/master/README-Eng.md

## About

This example is part of the **Waifu2x-Vulkan-Library**  
Please make sure you have completed the previous steps before following this example  
https://github.com/Aloento/Waifu2x-Vulkan-Library/blob/master/README-Eng.md

## Exports
We can see the functions that will be exported in `wrapper.h`
```c++
Waifu2xWrapper();
void setInput(path_t input);
void setOutput(path_t output);
void setNoise(int p_noise);
void setScale(int p_scale);
void setTileSize(std::vector<int> size);
void setModel(path_t p_model);
void setGpu(std::vector<int> gpu);
void setJobsLoad(int load);
void setJobProc(std::vector<int> proc);
void setJobSave(int save);
void setTtaMode(int mode);
void setFormat(path_t p_format);
int execute();
```

* There can be at most **one** instance of `Waifu2xWrapper` in a program  
  NCNN and GPU instances are created and await future operations  

* `setInput` and `setOutput` are required, they require a **string**

* Call `execute();` to start processing the image  
  
* For specific parameter settings, please refer to  
  https://github.com/nihui/waifu2x-ncnn-vulkan/blob/master/README.md#full-usages

## Dependencies
The following files / folders must be in the same directory  
* `libWaifu2x.dll`
* `vcomp140.dll`
* `models`
* Built executable program

`vcomp140.dll` is the OpenMP RT, which is **not** necessary

## Building
To run this example, you need to be in Windows 10

* Visual Studio and **.NET 5 Tool Chains**  
  https://visualstudio.microsoft.com/downloads/

Then just open the `Waifu2x-Vulkan-CSharp.sln` project and start building
