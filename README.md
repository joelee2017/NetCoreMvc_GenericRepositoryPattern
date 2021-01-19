# NetCoreMvc_GenericRepositoryPattern
GenericRepositoryPattern

一、IGenericRepository 、GenericRepository 建立

二、調整注入方式，提取

三、兩種版本注入方式

```c#
//第一種版本
// 注入 Repository
services.InJectionByGenericRepository();
 
// 注入 Service
services.InJectionByService("Service");
 
//第二種版本
// 注入 Interface
services.InJectionByInterface(new List<string>() { "Service", "Repository" });
 
// 注入 Class
services.InJectionByClass(new List<string>() { "Service", "Repository" });
 
// 注入 Generic
services.InJectionByGeneric("Model", new List<string>() { "Repository" });
```