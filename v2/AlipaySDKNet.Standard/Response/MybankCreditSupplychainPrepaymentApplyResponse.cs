using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditSupplychainPrepaymentApplyResponse.
    /// </summary>
    public class MybankCreditSupplychainPrepaymentApplyResponse : AopResponse
    {
        /// <summary>
        /// 预付申请单编号。
        /// </summary>
        [XmlElement("prepayment_apply_no")]
        public string PrepaymentApplyNo { get; set; }
    }
}
