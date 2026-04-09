using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentBuyerIdentityInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RentBuyerIdentityInfo : AopObject
    {
        /// <summary>
        /// 买家姓名信息
        /// </summary>
        [XmlElement("buyer_name")]
        public string BuyerName { get; set; }

        /// <summary>
        /// 买家身份证号
        /// </summary>
        [XmlElement("id_number")]
        public string IdNumber { get; set; }

        /// <summary>
        /// 买家手机号
        /// </summary>
        [XmlElement("tel_number")]
        public string TelNumber { get; set; }
    }
}
