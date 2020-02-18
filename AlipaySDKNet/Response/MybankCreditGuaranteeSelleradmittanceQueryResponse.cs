using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditGuaranteeSelleradmittanceQueryResponse.
    /// </summary>
    public class MybankCreditGuaranteeSelleradmittanceQueryResponse : AopResponse
    {
        /// <summary>
        /// 查询decision是否准入
        /// </summary>
        [XmlElement("is_admitted")]
        public bool IsAdmitted { get; set; }

        /// <summary>
        /// 是否签约
        /// </summary>
        [XmlElement("is_signed")]
        public bool IsSigned { get; set; }
    }
}
