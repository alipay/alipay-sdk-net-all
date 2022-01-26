using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCustomerZmcardInfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCustomerZmcardInfoQueryModel : AopObject
    {
        /// <summary>
        /// 查看者的身份证号,A申请查看B的芝麻证信息，则传入A的身份证号，若是自己查看自己的，则传入自己的身份证号，无法确定查看者，则传入空
        /// </summary>
        [XmlElement("guest_cert_no")]
        public string GuestCertNo { get; set; }

        /// <summary>
        /// 芝麻证被查看人的身份证号
        /// </summary>
        [XmlElement("host_cert_no")]
        public string HostCertNo { get; set; }
    }
}
