using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CancelInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class CancelInfoDTO : AopObject
    {
        /// <summary>
        /// 取消类型,PAY_FAILED-未支付（超时关闭） RESERVATION_INFO_ERROR-订单信息有误 OTHER_BOOKING_CHANNEL-通过其它途径预订 TRIP_CHANGED-行程变更 REPEAT-重单 OTHER-其它
        /// </summary>
        [XmlElement("cancel_code")]
        public string CancelCode { get; set; }

        /// <summary>
        /// 取消原因
        /// </summary>
        [XmlElement("cancel_reason")]
        public string CancelReason { get; set; }

        /// <summary>
        /// 订单取消时间,格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("cancel_time")]
        public string CancelTime { get; set; }

        /// <summary>
        /// 取消罚金值,根据查询时间计算
        /// </summary>
        [XmlElement("penalty_amount")]
        public EtravelHotelSupplyPriceDTO PenaltyAmount { get; set; }
    }
}
