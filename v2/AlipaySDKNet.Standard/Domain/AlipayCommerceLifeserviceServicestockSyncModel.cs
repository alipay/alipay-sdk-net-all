using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceLifeserviceServicestockSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceLifeserviceServicestockSyncModel : AopObject
    {
        /// <summary>
        /// 三方服务项目id【需保证唯一性】
        /// </summary>
        [XmlElement("out_service_id")]
        public string OutServiceId { get; set; }

        /// <summary>
        /// 服务项目id【和out_service_id二选一】
        /// </summary>
        [XmlElement("service_id")]
        public string ServiceId { get; set; }

        /// <summary>
        /// 蚂蚁门店id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 库存状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 库存日期【必填】 格式 yyyy-MM-dd
        /// </summary>
        [XmlElement("stock_date")]
        public string StockDate { get; set; }

        /// <summary>
        /// 库存结束时间【必填】
        /// </summary>
        [XmlElement("stock_end_time")]
        public string StockEndTime { get; set; }

        /// <summary>
        /// 库存开始时间【必填】
        /// </summary>
        [XmlElement("stock_start_time")]
        public string StockStartTime { get; set; }
    }
}
