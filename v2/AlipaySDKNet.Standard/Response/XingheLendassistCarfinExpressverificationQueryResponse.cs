using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// XingheLendassistCarfinExpressverificationQueryResponse.
    /// </summary>
    public class XingheLendassistCarfinExpressverificationQueryResponse : AopResponse
    {
        /// <summary>
        /// 完整性校验结果
        /// </summary>
        [XmlElement("completeness_check_result")]
        public string CompletenessCheckResult { get; set; }

        /// <summary>
        /// 审批结果
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
