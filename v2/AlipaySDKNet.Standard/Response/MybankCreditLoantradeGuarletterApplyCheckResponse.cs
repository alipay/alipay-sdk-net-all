using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditLoantradeGuarletterApplyCheckResponse.
    /// </summary>
    public class MybankCreditLoantradeGuarletterApplyCheckResponse : AopResponse
    {
        /// <summary>
        /// 申请单号
        /// </summary>
        [XmlElement("apply_no")]
        public string ApplyNo { get; set; }

        /// <summary>
        /// 出函机构
        /// </summary>
        [XmlElement("inst_name")]
        public string InstName { get; set; }

        /// <summary>
        /// 验证结果
        /// </summary>
        [XmlElement("verified")]
        public bool Verified { get; set; }
    }
}
