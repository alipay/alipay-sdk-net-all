using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ScenicAuditInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ScenicAuditInfo : AopObject
    {
        /// <summary>
        /// 审核信息
        /// </summary>
        [XmlElement("audit_msg")]
        public string AuditMsg { get; set; }

        /// <summary>
        /// 审核结果
        /// </summary>
        [XmlElement("audit_status")]
        public string AuditStatus { get; set; }

        /// <summary>
        /// 内外id映射关系创建时间
        /// </summary>
        [XmlElement("import_gmt_create")]
        public string ImportGmtCreate { get; set; }

        /// <summary>
        /// 服务商景区ID
        /// </summary>
        [XmlElement("outer_id_isv")]
        public string OuterIdIsv { get; set; }

        /// <summary>
        /// 支付宝域内维护的景区外部id
        /// </summary>
        [XmlElement("outer_id_zfb")]
        public string OuterIdZfb { get; set; }

        /// <summary>
        /// 服务商负责的景区小程序APPID
        /// </summary>
        [XmlElement("scenic_app_id")]
        public string ScenicAppId { get; set; }

        /// <summary>
        /// 支付宝域景区ID
        /// </summary>
        [XmlElement("scenic_id")]
        public string ScenicId { get; set; }
    }
}
