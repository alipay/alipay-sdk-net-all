using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPcreditLoanSideloanrepayBudgetQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditLoanSideloanrepayBudgetQueryModel : AopObject
    {
        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 申请还款金额，单位元，小数点后保留两位。 为空或为0时，对借据做结清预算不做分摊；大于0时，对申请还款金额做分摊。
        /// </summary>
        [XmlElement("apply_repay_amount")]
        public string ApplyRepayAmount { get; set; }

        /// <summary>
        /// 扩展参数，预留字段
        /// </summary>
        [XmlElement("extension")]
        public string Extension { get; set; }

        /// <summary>
        /// 淘宝支用申请单号集合。提前还款场景下强制校验不为空，并基于传入的支用申请单号做试算；到期逾期还款场景下为空，基于还款场景进行试算。
        /// </summary>
        [XmlArray("loan_apply_no_list")]
        [XmlArrayItem("string")]
        public List<string> LoanApplyNoList { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 产品码, 信贷产品码销售外标 加 渠道编码组成，固定为: SL_PD_SALE_CODE-TAOTIAN
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 还款场景 PREPAY-提前还款 DUE_REPAY-到期逾期还款
        /// </summary>
        [XmlElement("repayment_scene")]
        public string RepaymentScene { get; set; }
    }
}
