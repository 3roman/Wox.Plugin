# 开发文档

## 项目简介

本项目为[Wox](https://github.com/Wox-launcher/Wox)插件开发，其功能是提供一种查询水蒸汽性质的便捷手段，水蒸汽计算方法为IAPWS-IF97公式。仅支持64位操作系统。

> Wox plugin for querying steam property with IAPWS-IF97 formulations
>
> 64-bit OS only

## 使用方法

触发关键字`SS`，查询关键字`压力+温度`，压力为绝对压力，温度为摄氏温度。

> The trigger keyword is `SS` and the query keywords are `Pressure+Temperature`.

点击列表项或回车可复制当前值。

> Click the list item or press `Enter` to copy the current value


<img src="https://raw.githubusercontent.com/lim42snec/Wox.Plugin.SteamTable/master/%E4%BD%BF%E7%94%A8%E6%96%B9%E6%B3%95.gif" alt="image" style="zoom: 50%;" />

## 引用列举

本项目至少引用了如下开源项目，在此感谢原作者的杰出工作：

- [长沙优易水蒸汽库](https://github.com/uesoft/UEWASPMobile)
- [Costura打包工具](https://github.com/Fody/Costura)

## 待完功能

- [x] 根据压力、温度查询蒸汽性质
- [x] 国际化
- [x] 根据饱和压力查询饱和汽、饱和水性质
- [ ] 根据饱和温度查询饱和汽、饱和水性质
- [ ] 根据压力、比熵查询蒸汽性质
- [ ] 根据压力、比焓查询蒸汽性质
- [ ] 根据压力、干度查询蒸汽性质

