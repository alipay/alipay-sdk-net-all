using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantIndirectPromotaskSyncResponse.
    /// </summary>
    public class AlipayMerchantIndirectPromotaskSyncResponse : AopResponse
    {
        /// <summary>
        /// 任务同步结果，true/false
        /// </summary>
        [XmlElement("result_status")]
        public bool ResultStatus { get; set; }
    }
}
