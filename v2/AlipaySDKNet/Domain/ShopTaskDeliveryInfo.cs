using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ShopTaskDeliveryInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ShopTaskDeliveryInfo : AopObject
    {
        /// <summary>
        /// ● PRODUCING：生产中 ● DELIVERING：已发货 为空时代表支付宝暂时还未处理该单
        /// </summary>
        [XmlElement("delivery_status")]
        public string DeliveryStatus { get; set; }

        /// <summary>
        /// 快递公司名称，可空
        /// </summary>
        [XmlElement("logistics_name")]
        public string LogisticsName { get; set; }

        /// <summary>
        /// 快递单号，可空
        /// </summary>
        [XmlElement("way_bill_no")]
        public string WayBillNo { get; set; }
    }
}
