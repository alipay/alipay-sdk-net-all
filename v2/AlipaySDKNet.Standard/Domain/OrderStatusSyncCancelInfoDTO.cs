using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OrderStatusSyncCancelInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class OrderStatusSyncCancelInfoDTO : AopObject
    {
        /// <summary>
        /// PAY_FAILED-未支付（超时关闭） RESERVATION_INFO_ERROR-订单信息有误 OTHER_BOOKING_CHANNEL-通过其它途径预订 TRIP_CHANGED-行程变更 REPEAT-重单 USER_AGREE-用户协商一致取消 PRICE_CHANGE-变价 NOSHOW-用户未入住 FULLY_BOOKED：满房 OTHER-其它
        /// </summary>
        [XmlElement("cancel_code")]
        public string CancelCode { get; set; }

        /// <summary>
        /// 文字描述
        /// </summary>
        [XmlElement("cancel_reason")]
        public string CancelReason { get; set; }

        /// <summary>
        /// 取消罚金
        /// </summary>
        [XmlElement("penalty_amount")]
        public EtravelHotelSupplyPriceDTO PenaltyAmount { get; set; }
    }
}
