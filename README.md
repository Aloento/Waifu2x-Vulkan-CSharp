# Waifu2x-Vulkan-CSharp

Waifu2x-Vulkan-Library的C#使用范例

## 关于

本范例是**Waifu2x-Vulkan-Library**的一部分  
参考本范例前请先确保已经完成前序步骤  
https://github.com/Aloento/Waifu2x-Vulkan-Library

## 导出表
我们可以在 wrapper.h 中看到会被导出的函数  
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

* 在一个程序周期中最多只能有一个`Waifu2xWrapper`的实例  
  初始化实例后会创建NCNN和GPU实例，并等待后续操作

* `setInput` 和 `setOutput` 是必须的，它们要求传入一个`string`

* 调用 `execute();` 开始处理图像
  
* 具体参数设置请参考 https://github.com/nihui/waifu2x-ncnn-vulkan/blob/master/README.md#full-usages

## 依赖
以下文件 / 文件夹必须在同一个目录下  
* `libWaifu2x.dll` 库文件  
* `vcomp140.dll` 库文件  
* `models` 模型文件夹  
* 生成的可执行程序  

其中，`vcomp140.dll` 是 OpenMP 多线程库，它**不是**必要的  

## 运行
要运行本范例，你需要在Windows 10中

* 安装最新的Visual Studio和 **.NET 5工具链**  
  https://visualstudio.microsoft.com/zh-hans/downloads/

随后打开`Waifu2x-Vulkan-CSharp.sln`工程并开始调试即可
