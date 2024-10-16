using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppCommunityDeliveryidentityDetectModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppCommunityDeliveryidentityDetectModel : AopObject
    {
        /// <summary>
        /// 城市名
        /// </summary>
        [XmlElement("city_name")]
        public string CityName { get; set; }

        /// <summary>
        /// 标识唯一小区id
        /// </summary>
        [XmlElement("community_id")]
        public string CommunityId { get; set; }

        /// <summary>
        /// 小区名
        /// </summary>
        [XmlElement("community_name")]
        public string CommunityName { get; set; }

        /// <summary>
        /// 物业编码
        /// </summary>
        [XmlElement("company_code")]
        public string CompanyCode { get; set; }

        /// <summary>
        /// 物业公司名字
        /// </summary>
        [XmlElement("company_name")]
        public string CompanyName { get; set; }

        /// <summary>
        /// 骑手支付宝的openId。
        /// </summary>
        [XmlElement("delivery_open_id")]
        public string DeliveryOpenId { get; set; }

        /// <summary>
        /// 骑手支付宝的userId。
        /// </summary>
        [XmlElement("delivery_user_id")]
        public string DeliveryUserId { get; set; }
    }
}
