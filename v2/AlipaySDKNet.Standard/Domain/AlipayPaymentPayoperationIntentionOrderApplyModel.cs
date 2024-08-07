using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPaymentPayoperationIntentionOrderApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPaymentPayoperationIntentionOrderApplyModel : AopObject
    {
        /// <summary>
        /// 业务id，作为幂等，需要确保唯一性，用于表示该业务的唯一编码
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 用户手机号
        /// </summary>
        [XmlElement("mobile_phone")]
        public string MobilePhone { get; set; }

        /// <summary>
        /// 订单交易是的订单交易号
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 是否为支付宝支付（true表示为支付宝支付）
        /// </summary>
        [XmlElement("pay_by_alipay")]
        public bool PayByAlipay { get; set; }

        /// <summary>
        /// 表示具体订单创建的时间
        /// </summary>
        [XmlElement("pay_time")]
        public string PayTime { get; set; }

        /// <summary>
        /// 用于匹配用户权益文案
        /// </summary>
        [XmlElement("right_code")]
        public string RightCode { get; set; }

        /// <summary>
        /// 来源场景Code,用于作为日志来源
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 发送消息原因
        /// </summary>
        [XmlElement("send_reason")]
        public string SendReason { get; set; }

        /// <summary>
        /// 调用方系统名称
        /// </summary>
        [XmlElement("source_code")]
        public string SourceCode { get; set; }
    }
}
