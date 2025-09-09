using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingVerificationTradeSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingVerificationTradeSyncModel : AopObject
    {
        /// <summary>
        /// SYNC：交易信息回传 VERIFY：核销信息上报
        /// </summary>
        [XmlElement("action_type")]
        public string ActionType { get; set; }

        /// <summary>
        /// 支付宝订单号，非必填，如撤销交易信息回传/核销上报，则需传入该参数
        /// </summary>
        [XmlElement("alipay_refund_no")]
        public string AlipayRefundNo { get; set; }

        /// <summary>
        /// 支付宝交易号，用于识别交易信息
        /// </summary>
        [XmlElement("alipay_trade_no")]
        public string AlipayTradeNo { get; set; }

        /// <summary>
        /// 本次同步的资格相关业务信息，相同交易号相同操作类型时，若业务参数一致则视为幂等重试，否则视为交易信息补传，将重新提交核验平台
        /// </summary>
        [XmlElement("biz_info")]
        public string BizInfo { get; set; }

        /// <summary>
        /// 交易/退款时间，格式： yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("operation_time")]
        public string OperationTime { get; set; }

        /// <summary>
        /// 外部订单号
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 支付宝分配的场景编码，用于识别活动场景及区域等信息
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }
    }
}
