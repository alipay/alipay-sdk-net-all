using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcRecyclinginvoiceBatchdepositQueryResponse.
    /// </summary>
    public class AlipayCommerceEcRecyclinginvoiceBatchdepositQueryResponse : AopResponse
    {
        /// <summary>
        /// 批次请款单ID
        /// </summary>
        [XmlElement("batch_deposit_id")]
        public string BatchDepositId { get; set; }

        /// <summary>
        /// 出资银行卡号
        /// </summary>
        [XmlElement("deposit_account_no")]
        public string DepositAccountNo { get; set; }

        /// <summary>
        /// 待调拨金额(单位：元)
        /// </summary>
        [XmlElement("deposit_amount")]
        public string DepositAmount { get; set; }

        /// <summary>
        /// 出资银行
        /// </summary>
        [XmlElement("deposit_bank_name")]
        public string DepositBankName { get; set; }

        /// <summary>
        /// 待调拨的订单笔数
        /// </summary>
        [XmlElement("deposit_count")]
        public string DepositCount { get; set; }

        /// <summary>
        /// 批次调拨状态
        /// </summary>
        [XmlElement("deposit_status")]
        public string DepositStatus { get; set; }

        /// <summary>
        /// 调拨失败原因
        /// </summary>
        [XmlElement("fail_reason")]
        public string FailReason { get; set; }

        /// <summary>
        /// 订单信息列表
        /// </summary>
        [XmlArray("order_list")]
        [XmlArrayItem("batch_deposit_order_open_result")]
        public List<BatchDepositOrderOpenResult> OrderList { get; set; }

        /// <summary>
        /// 银行支付链接
        /// </summary>
        [XmlElement("pay_url")]
        public string PayUrl { get; set; }
    }
}
