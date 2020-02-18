using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditLoantradeShoptransferConsultResponse.
    /// </summary>
    public class MybankCreditLoantradeShoptransferConsultResponse : AopResponse
    {
        /// <summary>
        /// 咨询结果,allow(允许转让)/refuse(拒绝)
        /// </summary>
        [XmlElement("consult_result")]
        public string ConsultResult { get; set; }

        /// <summary>
        /// 拒绝码
        /// </summary>
        [XmlElement("refuse_code")]
        public string RefuseCode { get; set; }

        /// <summary>
        /// 拒绝文案
        /// </summary>
        [XmlElement("refuse_desc")]
        public string RefuseDesc { get; set; }
    }
}
