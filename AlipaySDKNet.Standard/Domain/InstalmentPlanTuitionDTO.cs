using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InstalmentPlanTuitionDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InstalmentPlanTuitionDTO : AopObject
    {
        /// <summary>
        /// 扣款金额， 类似11.12格式
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 交易完成信息
        /// </summary>
        [XmlElement("biz_time")]
        public string BizTime { get; set; }

        /// <summary>
        /// 订单ID，关联充值订单主键
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 扣款调度时间
        /// </summary>
        [XmlElement("schedule_time")]
        public string ScheduleTime { get; set; }

        /// <summary>
        /// 扣款序号
        /// </summary>
        [XmlElement("serial_no")]
        public long SerialNo { get; set; }

        /// <summary>
        /// 二级商户pid
        /// </summary>
        [XmlElement("smid")]
        public string Smid { get; set; }

        /// <summary>
        /// 扣款状态  1, "打款调度中" 2, "打款完成" 3, "退款中" 4, "退款完成"
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 代扣交易订单ID
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 支付宝用户pid
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
