using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TrafficAirticketOrderPassengerInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TrafficAirticketOrderPassengerInfo : AopObject
    {
        /// <summary>
        /// 证件号，与证件类型cert_type对应的号码
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 辅营商品信息
        /// </summary>
        [XmlArray("commodity_info_list")]
        [XmlArrayItem("traffic_airticket_order_commodity_info")]
        public List<TrafficAirticketOrderCommodityInfo> CommodityInfoList { get; set; }

        /// <summary>
        /// 乘机人手机号码
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 乘机人姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 用户的唯一标识，由商户侧生成
        /// </summary>
        [XmlElement("passenger_uuid")]
        public string PassengerUuid { get; set; }

        /// <summary>
        /// 是否本人，该乘机人是否为订单的下单人 1. true-该乘机人是订单的下单人 2. false-该乘机人不是订单的下单人
        /// </summary>
        [XmlElement("self")]
        public bool Self { get; set; }

        /// <summary>
        /// 航程信息
        /// </summary>
        [XmlArray("voyage_info_list")]
        [XmlArrayItem("traffic_airticket_order_voyage_info")]
        public List<TrafficAirticketOrderVoyageInfo> VoyageInfoList { get; set; }
    }
}
