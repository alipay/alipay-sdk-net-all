using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LeaseIndustryBean Data Structure.
    /// </summary>
    [Serializable]
    public class LeaseIndustryBean : AopObject
    {
        /// <summary>
        /// 商品可用的城市列表
        /// </summary>
        [XmlArray("available_city_list")]
        [XmlArrayItem("string")]
        public List<string> AvailableCityList { get; set; }

        /// <summary>
        /// 非负数。保留两位小数。币种默认CNY。单位：元
        /// </summary>
        [XmlElement("deposit_amount")]
        public string DepositAmount { get; set; }

        /// <summary>
        /// 租赁商品的新日描述
        /// </summary>
        [XmlElement("fresh_degree")]
        public string FreshDegree { get; set; }

        /// <summary>
        /// 商品最小租赁天数
        /// </summary>
        [XmlElement("rental_date")]
        public string RentalDate { get; set; }

        /// <summary>
        /// 商品是否支持租满即送
        /// </summary>
        [XmlElement("rental_free")]
        public string RentalFree { get; set; }

        /// <summary>
        /// 百分比，值范国0.00%-100.00%，保留两位小数
        /// </summary>
        [XmlElement("shipment_rate")]
        public string ShipmentRate { get; set; }

        /// <summary>
        /// 商品支持的发货城市列表
        /// </summary>
        [XmlElement("shipments")]
        public string Shipments { get; set; }
    }
}
