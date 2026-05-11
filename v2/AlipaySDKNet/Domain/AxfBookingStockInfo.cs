using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AxfBookingStockInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AxfBookingStockInfo : AopObject
    {
        /// <summary>
        /// 剩余可约数量，active时，这个数量应该大于0
        /// </summary>
        [XmlElement("available_quantity")]
        public long AvailableQuantity { get; set; }

        /// <summary>
        /// 库存状态（枚举） active      可预约 inactive    不可预约(无原因) full        不可预约(已约满)
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 时间  格式24小时制 09:30  不可超出门店营业时间 或者传时间段  09:00-10:00，则代表这个时间段的库存
        /// </summary>
        [XmlElement("time")]
        public string Time { get; set; }
    }
}
