using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// StoreRentalEbikeDetail Data Structure.
    /// </summary>
    [Serializable]
    public class StoreRentalEbikeDetail : AopObject
    {
        /// <summary>
        /// 车辆唯一标识
        /// </summary>
        [XmlElement("ebike_id")]
        public string EbikeId { get; set; }

        /// <summary>
        /// 车辆图片
        /// </summary>
        [XmlElement("ebike_image_url")]
        public string EbikeImageUrl { get; set; }

        /// <summary>
        /// 车辆名称
        /// </summary>
        [XmlElement("ebike_name")]
        public string EbikeName { get; set; }

        /// <summary>
        /// 车辆服务描述
        /// </summary>
        [XmlArray("ebike_service_desc")]
        [XmlArrayItem("string")]
        public List<string> EbikeServiceDesc { get; set; }

        /// <summary>
        /// 下单跳转链接
        /// </summary>
        [XmlElement("order_link_url")]
        public string OrderLinkUrl { get; set; }

        /// <summary>
        /// 租赁周期类型
        /// </summary>
        [XmlElement("rental_period_type")]
        public string RentalPeriodType { get; set; }

        /// <summary>
        /// 租赁价格
        /// </summary>
        [XmlElement("rental_price")]
        public string RentalPrice { get; set; }
    }
}
