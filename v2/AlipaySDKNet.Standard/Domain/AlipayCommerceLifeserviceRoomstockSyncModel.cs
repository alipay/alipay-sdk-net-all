using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceLifeserviceRoomstockSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceLifeserviceRoomstockSyncModel : AopObject
    {
        /// <summary>
        /// 三方场地id【需保证唯一性】
        /// </summary>
        [XmlElement("out_room_id")]
        public string OutRoomId { get; set; }

        /// <summary>
        /// 场地id【和out_room_id二选一】
        /// </summary>
        [XmlElement("room_id")]
        public string RoomId { get; set; }

        /// <summary>
        /// 蚂蚁门店id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 库存状态（枚举）【必填】 active 可预约 inactive 不可预约(无原因) full 不可预约(已约满)
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
