using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SecurityCertProfileExt Data Structure.
    /// </summary>
    [Serializable]
    public class SecurityCertProfileExt : AopObject
    {
        /// <summary>
        /// 账号类型
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 证书编号
        /// </summary>
        [XmlElement("cert_id")]
        public string CertId { get; set; }

        /// <summary>
        /// cert_storage_key
        /// </summary>
        [XmlElement("cert_storage_key")]
        public string CertStorageKey { get; set; }

        /// <summary>
        /// 证书唯一ID
        /// </summary>
        [XmlElement("cert_unique_id")]
        public string CertUniqueId { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [XmlElement("gmt_enable")]
        public string GmtEnable { get; set; }

        /// <summary>
        /// 存储键值对
        /// </summary>
        [XmlArray("openbizmock_map_ext")]
        [XmlArrayItem("openbizmock_map_ext")]
        public List<OpenbizmockMapExt> OpenbizmockMapExt { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// sec_id
        /// </summary>
        [XmlElement("sec_id")]
        public string SecId { get; set; }

        /// <summary>
        /// 失效时间
        /// </summary>
        [XmlElement("valid_end_time")]
        public string ValidEndTime { get; set; }

        /// <summary>
        /// 生效时间
        /// </summary>
        [XmlElement("valid_start_time")]
        public string ValidStartTime { get; set; }
    }
}
