using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SellerSyncRentBuyerExtInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SellerSyncRentBuyerExtInfo : AopObject
    {
        /// <summary>
        /// 买家身份证地址
        /// </summary>
        [XmlElement("cert_address")]
        public RentAddress CertAddress { get; set; }

        /// <summary>
        /// 买家的身份号码
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 买家的手机号码
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 买家的名字
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
