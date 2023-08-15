using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniOrderInstallmentCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniOrderInstallmentCreateModel : AopObject
    {
        /// <summary>
        /// 分期是否已经完结。 false:未完结 true:已完结
        /// </summary>
        [XmlElement("is_finish_performance")]
        public bool IsFinishPerformance { get; set; }

        /// <summary>
        /// 支付宝用户唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 交易组件订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 外部商户订单号，与order_id二者选一
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 期数
        /// </summary>
        [XmlElement("period_num")]
        public long PeriodNum { get; set; }

        /// <summary>
        /// 支付宝收单交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 分期类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 2088开头的16位纯数字，小程序场景下获取用户ID请参考：用户授权; 其它场景下获取用户ID请参考：网页授权获取用户信息;
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
