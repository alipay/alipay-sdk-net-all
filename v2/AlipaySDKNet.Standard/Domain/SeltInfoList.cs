using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SeltInfoList Data Structure.
    /// </summary>
    [Serializable]
    public class SeltInfoList : AopObject
    {
        /// <summary>
        /// 商保码理赔?额 单位：元 保留俩位?数
        /// </summary>
        [XmlElement("advance_pay")]
        public string AdvancePay { get; set; }

        /// <summary>
        /// 报销金额
        /// </summary>
        [XmlElement("claim_amount")]
        public string ClaimAmount { get; set; }

        /// <summary>
        /// 理赔详情URL
        /// </summary>
        [XmlElement("claim_detail")]
        public string ClaimDetail { get; set; }

        /// <summary>
        /// 理赔状态描述，理赔失败时原因描述
        /// </summary>
        [XmlElement("claim_status_desc")]
        public string ClaimStatusDesc { get; set; }

        /// <summary>
        /// 还款资金对方账号，保司还款的2088或医院2088或银行卡号
        /// </summary>
        [XmlElement("fund_opst_ac_nbr")]
        public string FundOpstAcNbr { get; set; }

        /// <summary>
        /// 还款资金对方帐号类型，01：银行账户；02：支付宝；03：网商二类户
        /// </summary>
        [XmlElement("fund_opst_ac_type")]
        public string FundOpstAcType { get; set; }

        /// <summary>
        /// 还款资金对方机构
        /// </summary>
        [XmlElement("fund_opst_org_nm")]
        public string FundOpstOrgNm { get; set; }

        /// <summary>
        /// 个?理赔?额 单位：元 保留俩位?数
        /// </summary>
        [XmlElement("personal_pay")]
        public string PersonalPay { get; set; }

        /// <summary>
        /// 打款时间，YYYY-MM-DD HH:MM:SS
        /// </summary>
        [XmlElement("repay_time")]
        public string RepayTime { get; set; }

        /// <summary>
        /// 结算单编号
        /// </summary>
        [XmlElement("selt_id")]
        public string SeltId { get; set; }

        /// <summary>
        /// 还款资金流水号，用来和支付宝账户资金流水进行对账
        /// </summary>
        [XmlElement("withdraw_no")]
        public string WithdrawNo { get; set; }
    }
}
