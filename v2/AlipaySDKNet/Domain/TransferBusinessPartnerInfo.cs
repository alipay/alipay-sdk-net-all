using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TransferBusinessPartnerInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TransferBusinessPartnerInfo : AopObject
    {
        /// <summary>
        /// 企业本地名称
        /// </summary>
        [XmlElement("business_local_name")]
        public string BusinessLocalName { get; set; }

        /// <summary>
        /// 企业名称
        /// </summary>
        [XmlElement("business_name")]
        public string BusinessName { get; set; }

        /// <summary>
        /// logo
        /// </summary>
        [XmlElement("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// logo类型
        /// </summary>
        [XmlElement("logo_type")]
        public string LogoType { get; set; }

        /// <summary>
        /// mcc
        /// </summary>
        [XmlElement("mcc")]
        public string Mcc { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        [XmlElement("operation_address")]
        public TransferAddressInfo OperationAddress { get; set; }
    }
}
