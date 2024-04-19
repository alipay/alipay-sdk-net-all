using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CertificateReverseResult Data Structure.
    /// </summary>
    [Serializable]
    public class CertificateReverseResult : AopObject
    {
        /// <summary>
        /// 凭证id
        /// </summary>
        [XmlElement("certificate_id")]
        public string CertificateId { get; set; }

        /// <summary>
        /// 结果说明
        /// </summary>
        [XmlElement("msg")]
        public string Msg { get; set; }

        /// <summary>
        /// 撤销结果枚举
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }

        /// <summary>
        /// 撤销接口传入的核销操作单号
        /// </summary>
        [XmlElement("use_order_no")]
        public string UseOrderNo { get; set; }
    }
}
