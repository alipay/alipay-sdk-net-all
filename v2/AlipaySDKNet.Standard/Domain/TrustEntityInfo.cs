using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TrustEntityInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TrustEntityInfo : AopObject
    {
        /// <summary>
        /// 主体证件号，企业社会信用编码等
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 主体证件类型，暂时只支持 企业社会信用编码 或 居民身份证
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 主体名称，可以是企业名称或个人姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
