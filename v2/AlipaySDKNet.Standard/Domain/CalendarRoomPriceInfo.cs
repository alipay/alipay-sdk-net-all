using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CalendarRoomPriceInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CalendarRoomPriceInfo : AopObject
    {
        /// <summary>
        /// 入住酒店日期
        /// </summary>
        [XmlElement("check_in_date")]
        public string CheckInDate { get; set; }

        /// <summary>
        /// 所属商品ID
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }
    }
}
