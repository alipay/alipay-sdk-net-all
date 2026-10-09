using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerversionNobuildUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniInnerversionNobuildUploadModel : AopObject
    {
        /// <summary>
        /// 扩展信息，比如adaptorName、tinycliVersion、tinycliName、import-module、allowPrecompile、extJson、allowInstallDependency、aggregationMainAppId，如果没有特殊要求，tinycliVersion版本请用最新的： https://registry.npm.alibaba-inc.com/@alipay/tiny-cli/huoban-prod
        /// </summary>
        [XmlElement("build_extra_info")]
        public string BuildExtraInfo { get; set; }

        /// <summary>
        /// jsapi权限文件
        /// </summary>
        [XmlElement("build_js_permission")]
        public string BuildJsPermission { get; set; }

        /// <summary>
        /// 小程序页面主入口。/index.html#page/component/index，该值需要和extendInfo中的page参数保持一致
        /// </summary>
        [XmlElement("build_main_url")]
        public string BuildMainUrl { get; set; }

        /// <summary>
        /// 打包平台扩展信息
        /// </summary>
        [XmlElement("build_qcloud_info")]
        public string BuildQcloudInfo { get; set; }

        /// <summary>
        /// 小程序版本
        /// </summary>
        [XmlElement("build_version")]
        public string BuildVersion { get; set; }

        /// <summary>
        /// 已经构建过的amr包大小，单位是字节，建议如实填写
        /// </summary>
        [XmlElement("builded_package_size")]
        public string BuildedPackageSize { get; set; }

        /// <summary>
        /// 已经构建的包地址，目前主要自行构建的场景使用
        /// </summary>
        [XmlElement("builded_package_url")]
        public string BuildedPackageUrl { get; set; }

        /// <summary>
        /// 构建好的插件包amr大小
        /// </summary>
        [XmlElement("builded_plugin_size")]
        public string BuildedPluginSize { get; set; }

        /// <summary>
        /// 构建好的插件包地址
        /// </summary>
        [XmlElement("builded_plugin_url")]
        public string BuildedPluginUrl { get; set; }

        /// <summary>
        /// 一个端的标识，用于区分不同的客户端，每接入一个客户端，都需要向小程序应用中心申请bundleId入驻
        /// </summary>
        [XmlElement("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 组件参数
        /// </summary>
        [XmlElement("components")]
        public string Components { get; set; }

        /// <summary>
        /// 上传调试版的接入租户类型
        /// </summary>
        [XmlElement("inst_code")]
        public string InstCode { get; set; }

        /// <summary>
        /// 小程序id
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 2.0已经构建过的amr包大小，单位是字节，主要是给自行构建的场景使用
        /// </summary>
        [XmlElement("new_builded_package_size")]
        public string NewBuildedPackageSize { get; set; }

        /// <summary>
        /// 2.0产物包地址
        /// </summary>
        [XmlElement("new_builded_package_url")]
        public string NewBuildedPackageUrl { get; set; }

        /// <summary>
        /// 构建好的插件包amr大小
        /// </summary>
        [XmlElement("new_builded_plugin_size")]
        public string NewBuildedPluginSize { get; set; }

        /// <summary>
        /// 构建好的插件包地址
        /// </summary>
        [XmlElement("new_builded_plugin_url")]
        public string NewBuildedPluginUrl { get; set; }

        /// <summary>
        /// 否免加签, true的时候代表传过来的是加签后的包地址
        /// </summary>
        [XmlElement("no_sign")]
        public bool NoSign { get; set; }

        /// <summary>
        /// 小程序代码中引用的插件列表，包含插件id和插件版本信息，业务方需要自行解析源码包的app.json里面的plugins信息
        /// </summary>
        [XmlArray("plugin_refs")]
        [XmlArrayItem("mini_app_plugin_reference")]
        public List<MiniAppPluginReference> PluginRefs { get; set; }

        /// <summary>
        /// 构建好的分包信息
        /// </summary>
        [XmlArray("sub_packages")]
        [XmlArrayItem("sub_package_info")]
        public List<SubPackageInfo> SubPackages { get; set; }
    }
}
