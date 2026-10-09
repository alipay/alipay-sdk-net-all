using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntfarmUserDonationRecord Data Structure.
    /// </summary>
    [Serializable]
    public class AntfarmUserDonationRecord : AopObject
    {
        /// <summary>
        /// 单次捐爱心时间
        /// </summary>
        [XmlElement("charity_time")]
        public string CharityTime { get; set; }

        /// <summary>
        /// 单次捐爱心数量
        /// </summary>
        [XmlElement("donation_amount")]
        public long DonationAmount { get; set; }
    }
}
