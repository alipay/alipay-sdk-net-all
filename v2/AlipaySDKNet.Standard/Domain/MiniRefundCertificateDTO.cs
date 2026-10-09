using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MiniRefundCertificateDTO Data Structure.
    /// </summary>
    [Serializable]
    public class MiniRefundCertificateDTO : AopObject
    {
        /// <summary>
        /// 本地商品对应的凭证id
        /// </summary>
        [XmlElement("certificate_id")]
        public string CertificateId { get; set; }

        /// <summary>
        /// 本地商品次卡对应的次序号
        /// </summary>
        [XmlElement("serial_no")]
        public string SerialNo { get; set; }
    }
}
