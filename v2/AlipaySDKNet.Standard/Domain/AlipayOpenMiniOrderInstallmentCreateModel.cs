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
        /// 续租场景分期数，当分期类型为RELET时，该字段必填
        /// </summary>
        [XmlElement("addon_period_num")]
        public long AddonPeriodNum { get; set; }

        /// <summary>
        /// 当installment_no_type为PERIOD时，填写分期数
        /// </summary>
        [XmlElement("installment_no")]
        public string InstallmentNo { get; set; }

        /// <summary>
        /// 分期数类型
        /// </summary>
        [XmlElement("installment_no_type")]
        public string InstallmentNoType { get; set; }

        /// <summary>
        /// 当分期类型为RENT，       期数为1时，分期金额=首期金额；       期数非1时，分期金额=每期金额，如果有尾期金额，最后一期分期金额=尾期金额；   当分期类型为BUYOUT，分期金额=买断价 buyout_price；    当分期类型为RELET，分期金额即续租金额；
        /// </summary>
        [XmlElement("installment_price")]
        public string InstallmentPrice { get; set; }

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
        /// 分期单外部请求号。由商家自定义，64个字符以内，仅支持字母、数字、下划线且需保证在商户端不重复。 其他请求参数不变时重复请求会幂等返回分期单号。
        /// </summary>
        [XmlElement("out_installment_order_id")]
        public string OutInstallmentOrderId { get; set; }

        /// <summary>
        /// 外部商户订单号
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 普通分期数，当分期类型为RENT或BUYOUT时，该字段必填
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
