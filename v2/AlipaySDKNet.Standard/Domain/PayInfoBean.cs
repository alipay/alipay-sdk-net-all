using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PayInfoBean Data Structure.
    /// </summary>
    [Serializable]
    public class PayInfoBean : AopObject
    {
        /// <summary>
        /// 支付完成时间,格式yyyyMMddHHMMSS，如2009年12月25日9点10分10秒
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 商户名称
        /// </summary>
        [XmlElement("mer_name")]
        public string MerName { get; set; }

        /// <summary>
        /// 服务商订单号
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 用户账单上的交易订单号
        /// </summary>
        [XmlElement("out_trans_id")]
        public string OutTransId { get; set; }

        /// <summary>
        /// 消费者实付金额，单位：元
        /// </summary>
        [XmlElement("pay_amt")]
        public string PayAmt { get; set; }

        /// <summary>
        /// 第三方支付机构商户ID，该字段跟wx_org联动，当前场景为huifu_id
        /// </summary>
        [XmlElement("thirdpay_mer_id")]
        public string ThirdpayMerId { get; set; }

        /// <summary>
        /// thirdpay_org
        /// </summary>
        [XmlElement("thirdpay_org")]
        public string ThirdpayOrg { get; set; }

        /// <summary>
        /// 交易金额,单位：元
        /// </summary>
        [XmlElement("trans_amt")]
        public string TransAmt { get; set; }

        /// <summary>
        /// 交易时间,格式：HHMMSS；示例值：102938
        /// </summary>
        [XmlElement("trans_time")]
        public string TransTime { get; set; }
    }
}
