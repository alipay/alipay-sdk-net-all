using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GreenOrderReceiptSendInfo Data Structure.
    /// </summary>
    [Serializable]
    public class GreenOrderReceiptSendInfo : AopObject
    {
        /// <summary>
        /// 订单回传失败字典值对应数值：DENGHUO_ORDER_NOT_SUPPORT、ORDER_HAS_SYNC
        /// </summary>
        [XmlElement("failure_code")]
        public string FailureCode { get; set; }

        /// <summary>
        /// 订单回传失败错误原因：不支持灯火订单同步、订单已同步
        /// </summary>
        [XmlElement("failure_reason")]
        public string FailureReason { get; set; }

        /// <summary>
        /// 外部商户订单号，out_biz_no唯—对应一笔订单。
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 订单所对应的支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
