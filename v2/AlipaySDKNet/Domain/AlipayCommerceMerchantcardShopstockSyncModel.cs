using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMerchantcardShopstockSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMerchantcardShopstockSyncModel : AopObject
    {
        /// <summary>
        /// 门店id【必填】
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 库存状态（枚举）【必填】 active      可预约 inactive    不可预约(无原因) full        不可预约(已约满)
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
