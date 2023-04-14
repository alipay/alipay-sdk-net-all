using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerversionPreviewUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniInnerversionPreviewUploadModel : AopObject
    {
        /// <summary>
        /// 构建参数- JSAPI 权限文件, JSON 字符串
        /// </summary>
        [XmlElement("build_js_permission")]
        public string BuildJsPermission { get; set; }

        /// <summary>
        /// 构建参数-IDE 构建好的包地址，如果是免加签场景该字段对应的是加签后的包地址
        /// </summary>
        [XmlElement("build_pkg_url")]
        public string BuildPkgUrl { get; set; }

        /// <summary>
        /// 构建参数-IDE 构建好的plugin包地址，小程序插件的有两个构建产物client包和plugin包，该场景下client包地址通过build_pkg_url传递，plugin包地址通过本参数传递
        /// </summary>
        [XmlElement("build_plugin_url")]
        public string BuildPluginUrl { get; set; }

        /// <summary>
        /// 包大小,免加签场景这里指加签包大小
        /// </summary>
        [XmlElement("builded_package_size")]
        public long BuildedPackageSize { get; set; }

        /// <summary>
        /// 构建好的插件包大小，对应免加签场景是加签后的包地址大小
        /// </summary>
        [XmlElement("builded_plugin_size")]
        public long BuildedPluginSize { get; set; }

        /// <summary>
        /// 一个端的标识，用于区分不同的客户端，每接入一个客户端，都需要向小程序应用中心申请bundelId入驻
        /// </summary>
        [XmlElement("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 业务扩展属性
        /// </summary>
        [XmlElement("extend_info")]
        public string ExtendInfo { get; set; }

        /// <summary>
        /// 上传调试版的接入租户类型。
        /// </summary>
        [XmlElement("inst_code")]
        public string InstCode { get; set; }

        /// <summary>
        /// 小程序主入口
        /// </summary>
        [XmlElement("main_url")]
        public string MainUrl { get; set; }

        /// <summary>
        /// 小程序ID
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 构建参数-IDE 构建好的appx2.0包地址，如果是免加签场景该字段对应的是加签后的包地址
        /// </summary>
        [XmlElement("new_build_pkg_url")]
        public string NewBuildPkgUrl { get; set; }

        /// <summary>
        /// 构建参数-IDE  构建好的plugin包地址，小程序插件的有两个构建产物client包和plugin包，该场景下client包地址通过build_pkg_url传递，plugin包地址通过本参数传递
        /// </summary>
        [XmlElement("new_build_plugin_url")]
        public string NewBuildPluginUrl { get; set; }

        /// <summary>
        /// 包大小,免加签场景这里指加签包大小
        /// </summary>
        [XmlElement("new_builded_package_size")]
        public long NewBuildedPackageSize { get; set; }

        /// <summary>
        /// appx2.0构建好的插件包大小,免加签场景是加签后的包大小
        /// </summary>
        [XmlElement("new_builded_plugin_size")]
        public long NewBuildedPluginSize { get; set; }

        /// <summary>
        /// 是否免加签，当true的时候代表不需要加签即传过来的包地址是加签好的地址
        /// </summary>
        [XmlElement("no_sign")]
        public bool NoSign { get; set; }

        /// <summary>
        /// 小程序代码中引用的插件列表，包含插件id和插件版本信息
        /// </summary>
        [XmlArray("plugin_refs")]
        [XmlArrayItem("mini_app_plugin_reference")]
        public List<MiniAppPluginReference> PluginRefs { get; set; }

        /// <summary>
        /// 预览类型，目前分为“DEBUG(调试版)、TRIAL(试用版)”
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 分包信息
        /// </summary>
        [XmlArray("sub_packages")]
        [XmlArrayItem("sub_package")]
        public List<SubPackage> SubPackages { get; set; }
    }
}
