using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BizFlowInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BizFlowInfo : AopObject
    {
        /// <summary>
        /// 业务发生额，币种为人民币(元)
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 业务单时间
        /// </summary>
        [XmlElement("biz_date")]
        public string BizDate { get; set; }

        /// <summary>
        /// 业务单据号
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 仅支持字母、数字，该条流水的唯一标识
        /// </summary>
        [XmlElement("flow_no")]
        public string FlowNo { get; set; }

        /// <summary>
        /// 成功
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 业务单收款方账号
        /// </summary>
        [XmlElement("payee_account_no")]
        public string PayeeAccountNo { get; set; }

        /// <summary>
        /// 业务单付款方账号
        /// </summary>
        [XmlElement("payer_account_no")]
        public string PayerAccountNo { get; set; }
    }
}
