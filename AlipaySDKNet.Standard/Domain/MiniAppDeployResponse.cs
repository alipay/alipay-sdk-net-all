using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MiniAppDeployResponse Data Structure.
    /// </summary>
    [Serializable]
    public class MiniAppDeployResponse : AopObject
    {
        /// <summary>
        /// 安卓最大版本号
        /// </summary>
        [XmlElement("android_client_max")]
        public string AndroidClientMax { get; set; }

        /// <summary>
        /// 安卓最低版本号
        /// </summary>
        [XmlElement("android_client_min")]
        public string AndroidClientMin { get; set; }

        /// <summary>
        /// 小程序版本号
        /// </summary>
        [XmlElement("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 端标识
        /// </summary>
        [XmlElement("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 发布版本
        /// </summary>
        [XmlElement("deploy_version")]
        public string DeployVersion { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// iOS最大版本号
        /// </summary>
        [XmlElement("ios_client_max")]
        public string IosClientMax { get; set; }

        /// <summary>
        /// iOS最小版本号
        /// </summary>
        [XmlElement("ios_client_min")]
        public string IosClientMin { get; set; }

        /// <summary>
        /// 小程序ID
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 包大小
        /// </summary>
        [XmlElement("package_size")]
        public string PackageSize { get; set; }

        /// <summary>
        /// 发布状态     INVALID("INVALID", "非法"),     INIT("INIT", "初始化状态"),     PRE_ONLINE("PRE_ONLINE", "预发");     GRAY("GRAY", "灰度"),     ONLINE("ONLINE", "上架"),     ABANDON("ABANDON", "废弃"),
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
