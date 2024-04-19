using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ServiceFeeExtInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ServiceFeeExtInfo : AopObject
    {
        /// <summary>
        /// 门店所在城市
        /// </summary>
        [XmlElement("city_name")]
        public string CityName { get; set; }

        /// <summary>
        /// 原账单消费金额 单位（元）
        /// </summary>
        [XmlElement("origin_consume_amount")]
        public string OriginConsumeAmount { get; set; }

        /// <summary>
        /// 原账单因公付金额 单位（元）
        /// </summary>
        [XmlElement("origin_peer_pay_amount")]
        public string OriginPeerPayAmount { get; set; }

        /// <summary>
        /// 企业码门店ID
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 企业码门店名称
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }
    }
}
