using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ParkingLotServiceInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ParkingLotServiceInfo : AopObject
    {
        /// <summary>
        /// 在线缴费服务名称
        /// </summary>
        [XmlElement("service_name")]
        public string ServiceName { get; set; }

        /// <summary>
        /// 停车场可提供的服务类型 发票服务：INVOICE_SERVICE 优惠套餐: DISCOUNT_PACKAGE 预约停车: RESERVED_PARKING
        /// </summary>
        [XmlElement("service_type")]
        public string ServiceType { get; set; }

        /// <summary>
        /// 商户提供服务对应的跳转链接
        /// </summary>
        [XmlElement("service_url")]
        public string ServiceUrl { get; set; }
    }
}
