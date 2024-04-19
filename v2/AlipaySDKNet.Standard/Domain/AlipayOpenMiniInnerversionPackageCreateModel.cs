using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerversionPackageCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniInnerversionPackageCreateModel : AopObject
    {
        /// <summary>
        /// 业务来源
        /// </summary>
        [XmlElement("app_origin")]
        public string AppOrigin { get; set; }

        /// <summary>
        /// 小程序版本
        /// </summary>
        [XmlElement("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 端信息
        /// </summary>
        [XmlElement("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 小程序ID，仅特殊场景使用，普通业务方无需关注该参数。
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 打包类型。预发包和覆盖率包
        /// </summary>
        [XmlElement("package_type")]
        public string PackageType { get; set; }

        /// <summary>
        /// pid. 伙伴链路（app_origin='HUOBAN'）时必填
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }
    }
}
