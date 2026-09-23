using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ThirdPartyRefundExceptionOrderList Data Structure.
    /// </summary>
    [Serializable]
    public class ThirdPartyRefundExceptionOrderList : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("certificate_id_list")]
        [XmlArrayItem("string")]
        public List<string> CertificateIdList { get; set; }

        /// <summary>
        /// 请求退款时，商家提供的拒绝退款原因
        /// </summary>
        [XmlElement("failure_reason")]
        public string FailureReason { get; set; }

        /// <summary>
        /// 退款超24h未完成处理，出现异常的时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [XmlElement("merchant_order_no")]
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// 平台订单号
        /// </summary>
        [XmlElement("platform_order_no")]
        public string PlatformOrderNo { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("product_name")]
        public string ProductName { get; set; }

        /// <summary>
        /// 退款金额(单位元)
        /// </summary>
        [XmlElement("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 用户发起退款时间
        /// </summary>
        [XmlElement("refund_apply_time")]
        public string RefundApplyTime { get; set; }

        /// <summary>
        /// 退款状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 订单退款异常产生的任务id，请记录此id，用于「三方码异常订单退款」接口中推进退款；一笔订单可能有多个任务id，请根据退款任务中的凭证清单判断是否推进退款
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }

        /// <summary>
        /// 支付交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
