using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryCommunityDeliveryrecentorderDetectModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryCommunityDeliveryrecentorderDetectModel : AopObject
    {
        /// <summary>
        /// 城市国标编码
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 小区名字
        /// </summary>
        [XmlElement("community_name")]
        public string CommunityName { get; set; }

        /// <summary>
        /// 物业唯一编码
        /// </summary>
        [XmlElement("company_code")]
        public string CompanyCode { get; set; }

        /// <summary>
        /// 物业公司名字
        /// </summary>
        [XmlElement("company_name")]
        public string CompanyName { get; set; }

        /// <summary>
        /// 骑手支付宝的openId
        /// </summary>
        [XmlElement("delivery_open_id")]
        public string DeliveryOpenId { get; set; }

        /// <summary>
        /// 骑手支付宝的userId
        /// </summary>
        [XmlElement("delivery_user_id")]
        public string DeliveryUserId { get; set; }
    }
}
