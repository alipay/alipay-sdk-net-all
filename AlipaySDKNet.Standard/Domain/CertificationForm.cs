using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CertificationForm Data Structure.
    /// </summary>
    [Serializable]
    public class CertificationForm : AopObject
    {
        /// <summary>
        /// 该字段用来表示抽佣的凭证单号，需要配套传certification_type，以确定具体单号代表的业务语义。
        /// </summary>
        [XmlElement("certification_no")]
        public string CertificationNo { get; set; }

        /// <summary>
        /// 凭证类型，用来确定certification_no代表的具体业务语义
        /// </summary>
        [XmlElement("certification_type")]
        public string CertificationType { get; set; }
    }
}
