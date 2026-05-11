using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AftersaleCertificateInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AftersaleCertificateInfo : AopObject
    {
        /// <summary>
        /// 售后次序号列表
        /// </summary>
        [XmlArray("aftersale_serial_info_vo_list")]
        [XmlArrayItem("aftersale_serial_info")]
        public List<AftersaleSerialInfo> AftersaleSerialInfoVoList { get; set; }

        /// <summary>
        /// 支付宝侧的凭证id
        /// </summary>
        [XmlElement("certificate_id")]
        public string CertificateId { get; set; }
    }
}
