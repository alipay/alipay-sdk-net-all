using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceLifeserviceTechnicianstockSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceLifeserviceTechnicianstockSyncModel : AopObject
    {
        /// <summary>
        /// 三方手艺人id【需保证唯一性】
        /// </summary>
        [XmlElement("out_technician_id")]
        public string OutTechnicianId { get; set; }

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

        /// <summary>
        /// 手艺人id【和out_technician_id二选一】
        /// </summary>
        [XmlElement("technician_id")]
        public string TechnicianId { get; set; }
    }
}
