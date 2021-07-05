using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechBlockchainFinanceTruspleLoanrepaySubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainFinanceTruspleLoanrepaySubmitModel : AopObject
    {
        /// <summary>
        /// 实还总金额，币种最小单位，如果是CNY，则单位分
        /// </summary>
        [XmlElement("actual_repaid_amount")]
        public long ActualRepaidAmount { get; set; }

        /// <summary>
        /// 外部合作伙伴的贷款合同号
        /// </summary>
        [XmlElement("external_loan_id")]
        public string ExternalLoanId { get; set; }

        /// <summary>
        /// 外部合作伙伴的还款请求号，用做业务幂等号
        /// </summary>
        [XmlElement("external_repay_request_id")]
        public string ExternalRepayRequestId { get; set; }

        /// <summary>
        /// 外部用户唯一标识
        /// </summary>
        [XmlElement("external_user_id")]
        public string ExternalUserId { get; set; }

        /// <summary>
        /// 还款资金来源： ALIPAY - 支付宝， UNIONPAY - 银联， TRADE_COLLECTION - 外贸回款
        /// </summary>
        [XmlElement("fund_channel")]
        public string FundChannel { get; set; }

        /// <summary>
        /// 转账附言： 1）支付宝渠道还款必有， 2）银联渠道还款没有， 3）外贸回款必有
        /// </summary>
        [XmlElement("fund_message")]
        public string FundMessage { get; set; }

        /// <summary>
        /// 机构代码
        /// </summary>
        [XmlElement("inst_code")]
        public string InstCode { get; set; }

        /// <summary>
        /// 分期明细列表
        /// </summary>
        [XmlArray("installment_details")]
        [XmlArrayItem("installment_detail")]
        public List<InstallmentDetail> InstallmentDetails { get; set; }

        /// <summary>
        /// 还款金额币种
        /// </summary>
        [XmlElement("repay_amount_currency")]
        public string RepayAmountCurrency { get; set; }

        /// <summary>
        /// 还款成功时间，格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("repay_time")]
        public string RepayTime { get; set; }

        /// <summary>
        /// 还款类型： PREPAY - 提前还款， DUE_REPAY - 到期还款， OVERDUE_REPAY - 逾期还款
        /// </summary>
        [XmlElement("repay_type")]
        public string RepayType { get; set; }
    }
}
