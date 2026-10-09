using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditLoantradePartnerPaymentApplyResponse.
    /// </summary>
    public class MybankCreditLoantradePartnerPaymentApplyResponse : AopResponse
    {
        /// <summary>
        /// 网商内部申请单编号，外部机构根据此编号查询申请状态。
        /// </summary>
        [XmlElement("in_apply_no")]
        public string InApplyNo { get; set; }
    }
}
