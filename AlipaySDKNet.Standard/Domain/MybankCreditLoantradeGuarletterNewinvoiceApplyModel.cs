using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankCreditLoantradeGuarletterNewinvoiceApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditLoantradeGuarletterNewinvoiceApplyModel : AopObject
    {
        /// <summary>
        /// 申请开票用户信息
        /// </summary>
        [XmlElement("apply_user_info")]
        public EnterpriseCustomerInfoVO ApplyUserInfo { get; set; }

        /// <summary>
        /// 保函单号
        /// </summary>
        [XmlElement("guar_order_no")]
        public string GuarOrderNo { get; set; }

        /// <summary>
        /// 开票金额
        /// </summary>
        [XmlElement("invoice_amt")]
        public CreditPayMoneyVO InvoiceAmt { get; set; }

        /// <summary>
        /// 1：普票 2：专票
        /// </summary>
        [XmlElement("invoice_type")]
        public string InvoiceType { get; set; }

        /// <summary>
        /// 接收信息
        /// </summary>
        [XmlElement("receive_info")]
        public ReceiveInfoVO ReceiveInfo { get; set; }

        /// <summary>
        /// 请求单号
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
