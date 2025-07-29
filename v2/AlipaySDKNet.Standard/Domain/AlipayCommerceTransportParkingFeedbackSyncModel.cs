using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportParkingFeedbackSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportParkingFeedbackSyncModel : AopObject
    {
        /// <summary>
        /// 服务商对于支付宝提供的异常行程处理的结果 枚举值 未处理: UNPROCESSED 处理中: PROCESSING 已处理: PROCESSED 不处理: NOT_PROCESSABLE
        /// </summary>
        [XmlElement("feedback_result")]
        public string FeedbackResult { get; set; }

        /// <summary>
        /// 用户反馈时间
        /// </summary>
        [XmlElement("feedback_time")]
        public string FeedbackTime { get; set; }

        /// <summary>
        /// 反馈类型
        /// </summary>
        [XmlElement("feedback_type")]
        public string FeedbackType { get; set; }

        /// <summary>
        /// 用户反馈的行程异常的原因
        /// </summary>
        [XmlElement("feedback_type_msg")]
        public string FeedbackTypeMsg { get; set; }

        /// <summary>
        /// 外部停车流水号(用于串通进场与出场信息)
        /// </summary>
        [XmlElement("out_serial_no")]
        public string OutSerialNo { get; set; }

        /// <summary>
        /// 支付宝停车平台ID，由支付宝定义的该停车场标识，同一个isv或商户范围内唯一。通过 alipay.eco.mycar.parking.parkinglotinfo.create (录入停车场信息)接口获取。
        /// </summary>
        [XmlElement("parking_id")]
        public string ParkingId { get; set; }

        /// <summary>
        /// 车牌颜色，车牌颜色，枚举支持： *BLUE：蓝。 *GREEN：绿。 *YELLOW：黄。 *WHITE：白。 *BLACK：黑。 *LIMEGREEN：黄绿色。
        /// </summary>
        [XmlElement("plate_color")]
        public string PlateColor { get; set; }

        /// <summary>
        /// 车牌号码
        /// </summary>
        [XmlElement("plate_no")]
        public string PlateNo { get; set; }
    }
}
