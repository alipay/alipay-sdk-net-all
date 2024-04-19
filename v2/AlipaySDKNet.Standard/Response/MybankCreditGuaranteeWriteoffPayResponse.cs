using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditGuaranteeWriteoffPayResponse.
    /// </summary>
    public class MybankCreditGuaranteeWriteoffPayResponse : AopResponse
    {
        /// <summary>
        /// 销账申请单号
        /// </summary>
        [XmlElement("writeoff_apply_no")]
        public string WriteoffApplyNo { get; set; }
    }
}
