using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SellerSyncRentFinancingExtInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SellerSyncRentFinancingExtInfo : AopObject
    {
        /// <summary>
        /// 需要融资的金额，币种：人民币
        /// </summary>
        [XmlElement("financing_amount")]
        public string FinancingAmount { get; set; }

        /// <summary>
        /// 融资期数
        /// </summary>
        [XmlElement("financing_period")]
        public RentPeriod FinancingPeriod { get; set; }

        /// <summary>
        /// 融资的利率(年化利率)，例如年化利率0.2%，字段值设置时为：0.2
        /// </summary>
        [XmlElement("financing_rate")]
        public string FinancingRate { get; set; }

        /// <summary>
        /// 融资人的ID，取值：为支付宝的PID
        /// </summary>
        [XmlElement("fundraiser_id")]
        public string FundraiserId { get; set; }

        /// <summary>
        /// 融资人的名称，一般为融资公司的名称
        /// </summary>
        [XmlElement("fundraiser_name")]
        public string FundraiserName { get; set; }

        /// <summary>
        /// 融资人的OpenId，取值参考：openApi开发网关接入文档
        /// </summary>
        [XmlElement("fundraiser_open_id")]
        public string FundraiserOpenId { get; set; }

        /// <summary>
        /// 资方的支付宝PID，取值：请联系资方获取
        /// </summary>
        [XmlElement("invest_id")]
        public string InvestId { get; set; }

        /// <summary>
        /// 资方的支付宝PID，取值：请联系资方获取
        /// </summary>
        [XmlElement("invest_open_id")]
        public string InvestOpenId { get; set; }

        /// <summary>
        /// 融资人收款账户，取值：企业支付宝的账号PID
        /// </summary>
        [XmlElement("payee_account")]
        public string PayeeAccount { get; set; }

        /// <summary>
        /// 融资人收款账户openId，取值参考：openApi开发网关接入文档
        /// </summary>
        [XmlElement("payee_account_open_id")]
        public string PayeeAccountOpenId { get; set; }

        /// <summary>
        /// 收款备注说明，示例：融资放款
        /// </summary>
        [XmlElement("payee_memo")]
        public string PayeeMemo { get; set; }

        /// <summary>
        /// 还款的方式，例如：等额本息/等额本差
        /// </summary>
        [XmlElement("repayment_type")]
        public string RepaymentType { get; set; }
    }
}
