using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiServindustryReservationLeadsModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiServindustryReservationLeadsModifyModel : AopObject
    {
        /// <summary>
        /// 实际到店时间：status_mark==CUSTOMER_ARRIVED时，gmt_arrived不能为空
        /// </summary>
        [XmlElement("gmt_arrived")]
        public string GmtArrived { get; set; }

        /// <summary>
        /// 预约到店时间：status_mark==CUSTOMER_ACCEPTED时，gmt_reserve不能为空
        /// </summary>
        [XmlElement("gmt_reserve")]
        public string GmtReserve { get; set; }

        /// <summary>
        /// 商家备注：和status_mark不能同时为空
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 预约记录ID
        /// </summary>
        [XmlElement("reservation_record_id")]
        public string ReservationRecordId { get; set; }

        /// <summary>
        /// 客资状态：和memo不能同时为空 PROCESSING("待跟进"), CUSTOMER_ACCEPTED("待到店"), CUSTOMER_ARRIVED("已到店"), CUSTOMER_REJECTED("无意向"), IN_BLACK_LIST("黑名单"),
        /// </summary>
        [XmlElement("status_mark")]
        public string StatusMark { get; set; }
    }
}
