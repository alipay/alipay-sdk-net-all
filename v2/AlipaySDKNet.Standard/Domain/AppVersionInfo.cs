using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AppVersionInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AppVersionInfo : AopObject
    {
        /// <summary>
        /// 版本号，一般为x.y.x格式，其中x、y、z都是数字
        /// </summary>
        [XmlElement("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 准入审核结果 （提审时 audit_rule 传 BASE_PROMOTE 时有该字段）
        /// </summary>
        [XmlElement("base_audit")]
        public string BaseAudit { get; set; }

        /// <summary>
        /// 小程序客户端类型，默认为支付宝端。常见支持如下客户端： com.alipay.alipaywallet：支付宝端； com.alibaba.android.rimet：DINGDING端； com.amap.app：高德端； com.alibaba.ailabs.genie.webapps：天猫精灵端； com.alipay.iot.xpaas：支付宝IoT端。 如需更多端投放，请联系业务BD。
        /// </summary>
        [XmlElement("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 是否可上架 true：可上架 false：不可上架 （version_status 为PROMOTE_AUDIT_REJECT有值） （提审时 audit_rule 传 BASE_PROMOTE 时有该字段）
        /// </summary>
        [XmlElement("can_release")]
        public string CanRelease { get; set; }

        /// <summary>
        /// 版本创建时间，精确到秒
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 营销审核结果： PASS：通过 REJECT：驳回 （提审时 audit_rule 传 BASE_PROMOTE 时有该字段）
        /// </summary>
        [XmlElement("promote_audit")]
        public string PromoteAudit { get; set; }

        /// <summary>
        /// 小程序版本描述，介绍此版本的主要变更和功能，5-500个字符。
        /// </summary>
        [XmlElement("version_description")]
        public string VersionDescription { get; set; }

        /// <summary>
        /// 版本状态
        /// </summary>
        [XmlElement("version_status")]
        public string VersionStatus { get; set; }
    }
}
