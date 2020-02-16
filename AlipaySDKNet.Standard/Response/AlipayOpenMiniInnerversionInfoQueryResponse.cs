using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniInnerversionInfoQueryResponse.
    /// </summary>
    public class AlipayOpenMiniInnerversionInfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 版本号
        /// </summary>
        [XmlElement("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 版本构建类型
        /// </summary>
        [XmlElement("build_source")]
        public string BuildSource { get; set; }

        /// <summary>
        /// 端信息
        /// </summary>
        [XmlElement("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 版本创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 版本描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 实例化模板参数
        /// </summary>
        [XmlElement("ext_json")]
        public string ExtJson { get; set; }

        /// <summary>
        /// 版本更新时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 版本灰度时间
        /// </summary>
        [XmlElement("gray_start_time")]
        public string GrayStartTime { get; set; }

        /// <summary>
        /// 小程序灰度比例值
        /// </summary>
        [XmlElement("gray_strategy")]
        public string GrayStrategy { get; set; }

        /// <summary>
        /// 小程序ID
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 版本下架时间
        /// </summary>
        [XmlElement("offline_time")]
        public string OfflineTime { get; set; }

        /// <summary>
        /// 包地址
        /// </summary>
        [XmlElement("package_url")]
        public string PackageUrl { get; set; }

        /// <summary>
        /// 引用插件信息
        /// </summary>
        [XmlArray("plugin_refs")]
        [XmlArrayItem("mini_app_plugin_info")]
        public List<MiniAppPluginInfo> PluginRefs { get; set; }

        /// <summary>
        /// 审核失败原因
        /// </summary>
        [XmlElement("reject_reason")]
        public string RejectReason { get; set; }

        /// <summary>
        /// 版本回滚时间
        /// </summary>
        [XmlElement("rollback_time")]
        public string RollbackTime { get; set; }

        /// <summary>
        /// 安全扫描结果
        /// </summary>
        [XmlElement("scan_result")]
        public string ScanResult { get; set; }

        /// <summary>
        /// 小程序版本截图，多个截图以逗号隔开
        /// </summary>
        [XmlElement("screen_shot_list")]
        public string ScreenShotList { get; set; }

        /// <summary>
        /// 版本上架时间
        /// </summary>
        [XmlElement("shelf_time")]
        public string ShelfTime { get; set; }

        /// <summary>
        /// 源码包地址
        /// </summary>
        [XmlElement("source_url")]
        public string SourceUrl { get; set; }

        /// <summary>
        /// 版本状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 模板构建参数
        /// </summary>
        [XmlElement("template_extra")]
        public string TemplateExtra { get; set; }

        /// <summary>
        /// 模板版本号
        /// </summary>
        [XmlElement("template_version")]
        public string TemplateVersion { get; set; }
    }
}
