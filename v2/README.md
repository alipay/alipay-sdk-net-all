[![NuGet](https://badge.fury.io/nu/AlipaySDKNet.Standard.svg)](https://badge.fury.io/nu/AlipaySDKNet.Standard)
[![FOSSA Status](https://app.fossa.com/api/projects/git%2Bgithub.com%2Falipay%2Falipay-sdk-net-all.svg?type=shield)](https://app.fossa.com/projects/git%2Bgithub.com%2Falipay%2Falipay-sdk-net-all?ref=badge_shield)
[![Codacy Badge](https://api.codacy.com/project/badge/Grade/068a5b3d1b984234bedba4cc8647ff8c)](https://www.codacy.com/manual/antopen/alipay-sdk-net-all?utm_source=github.com&amp;utm_medium=referral&amp;utm_content=alipay/alipay-sdk-net-all&amp;utm_campaign=Badge_Grade)
[![Build Status](https://www.travis-ci.org/alipay/alipay-sdk-net-all.svg?branch=dev)](https://www.travis-ci.org/alipay/alipay-sdk-net-all)
[![codecov](https://codecov.io/gh/alipay/alipay-sdk-net-all/branch/master/graph/badge.svg)](https://codecov.io/gh/alipay/alipay-sdk-net-all)

欢迎使用 Alipay SDK for .NET 。

Alipay SDK for .NET让您不用复杂编程即可访支付宝开放平台开放的各项能力，SDK可以自动帮您满足能力调用过程中所需的证书校验、加签、验签、发送HTTP请求等非功能性要求。

这里向您介绍如何获取 Alipay SDK for .NET 并开始调用。
如果您在使用 Alipay SDK for .NET 的过程中遇到任何问题，欢迎在当前 GitHub [提交 Issues](https://github.com/alipay/alipay-sdk-net-all/issues/new)。

## 环境要求
1. Alipay SDK for .NET同时提供基于.Net Framework和.Net Standard 2.0开发的版本，前者支持.Net Framework 3.5及其以上版本，后者支持.Net Framework 4.6.1、.Net Core 2.0及其以上版本。

2. 使用 Alipay SDK for .NET 之前 ，您需要先前往[支付宝开发平台-开发者中心](https://openhome.alipay.com/platform/developerIndex.htm)完成开发者接入的一些准备工作，包括创建应用、为应用添加功能包、设置应用的接口加签方式等。

3. 准备工作完成后，注意保存如下信息，后续将作为使用SDK的输入。

* 加签模式为公钥证书模式时（推荐）

`AppID`、`应用的私钥`、`应用的公钥证书文件`、`支付宝公钥证书文件`、`支付宝根证书文件`

* 加签模式为公钥模式时

`AppId`、`应用的私钥`、`应用的公钥`、`支付宝公钥`

## 安装依赖
推荐通过 NuGet 程序包管理器来安装依赖：

* 在 `解决方案资源管理器面板` 中右击您的项目选择 `管理 NuGet 程序包` 菜单，在打开的 `NuGet 管理面板` 中点击 `浏览` 选项卡输入 `AlipaySDKNet`，在下方列表中选择 `Authors` 为 `antopen` 由官方发布的NuGet包（根据您使用的框架选择`AlipaySDKNet`或`AlipaySDKNet.Standard`），点击 **安装** 即可。

* 或者通过 .NET CLI 工具来安装（以安装AlipaySDKNet.Standard为例）

    dotnet add package AlipaySDKNet.Standard

## 快速使用
以下这段代码示例向您展示了使用Alipay SDK for .NET调用一个API的3个主要步骤：
1. 创建DefaultAopClient实例并初始化。
2. 创建API请求对象并设置Model参数。
3. 发起请求并处理响应或异常。 

```csharp
using System;
using Aop.Api;
using Aop.Api.Request;
using Aop.Api.Response;
using Aop.Api.Domain;

namespace SDK.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // 1. 创建IAopClient实例
                IAopClient client = new DefaultAopClient(
                    "https://openapi.alipay.com/gateway.do",
                    "2019091767145019", //请更换为您的AppId
                    "MIIEowIBAAKCAQ ... ...", //请更换为您的PKCS1格式的应用私钥
                    "json", "1.0", "RSA2",
                    "utf-8", //请更换为您使用的字符集编码，推荐采用utf-8
                    false, GetCertParams());
                // 2. 创建使用的Open API对应的Request请求对象
                AlipayOpenOperationOpenbizmockBizQueryRequest request = GetRequest();
                // 3. 发起请求并处理响应
                AlipayOpenOperationOpenbizmockBizQueryResponse response = client.CertificateExecute(request);
                if (!response.IsError)
                {
                    Console.WriteLine("调用成功。");
                }
                else
                {
                    Console.WriteLine("调用失败，原因：" + response.Msg + "，" + response.SubMsg);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("调用遭遇异常，原因：" + e.Message);
                throw e;
            }
        }

        private static CertParams GetCertParams()
        {
            return new CertParams
            {
                //请更换为您的应用公钥证书文件路径
                AlipayPublicCertPath = "/home/foo/alipayCertPublicKey_RSA2.crt",
                //请更换您的支付宝公钥证书文件路径
                AppCertPath = "/home/foo/appCertPublicKey_2019090366875133.crt",
                //请更换为支付宝根证书文件路径
                RootCertPath = "/home/foo/alipayRootCert.crt"
            };
        }

        private static AlipayOpenOperationOpenbizmockBizQueryRequest GetRequest()
        {
            // 初始化Request，并填充Model属性。实际调用时请替换为您想要使用的API对应的Request对象。
            AlipayOpenOperationOpenbizmockBizQueryRequest request = new AlipayOpenOperationOpenbizmockBizQueryRequest();
            AlipayOpenOperationOpenbizmockBizQueryModel model = new AlipayOpenOperationOpenbizmockBizQueryModel
            {
                BizNo = "123456789"
            };
            request.SetBizModel(model);
            return request;
        }
    }
}
```

## 文档
[SDK文档首页](https://docs.open.alipay.com/54/103419/)

## 问题
不管您在使用SDK的过程中遇到任何问题，欢迎前往 [支付宝开放社区](https://forum.alipay.com/mini-app/channel/1100001)  发帖与支付宝工作人员和其他开发者一起交流。

注：为了提高开发者问题的响应时效，github本身的issue功能已关闭，支付宝开放社区中发帖的问题，通常会在2小时内响应。

## 变更日志
每个版本的详细更改记录在[变更日志](./CHANGELOG)中。

注：版本号最末一位修订号的增加（比如从`4.1.62`升级为`4.1.74`），意味着SDK的功能没有发生任何变化，仅仅是集成了更多的API的Request、Response、Domain类，此类变更默认不记录在变更日志中。

## 相关
* [支付宝开放平台](https://open.alipay.com/platform/home.htm)
* [支付宝开放平台文档中心](https://docs.open.alipay.com/catalog)
* [最新源码](https://github.com/alipay/alipay-sdk-net-all)

## 许可证
[![FOSSA Status](https://app.fossa.com/api/projects/git%2Bgithub.com%2Falipay%2Falipay-sdk-net-all.svg?type=large)](https://app.fossa.com/projects/git%2Bgithub.com%2Falipay%2Falipay-sdk-net-all?ref=badge_large)
