using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossFncGfaccenterConsolidationAcceptResponse.
    /// </summary>
    public class AlipayBossFncGfaccenterConsolidationAcceptResponse : AopResponse
    {
        /// <summary>
        /// 是否并账成功
        /// </summary>
        [XmlElement("consolidation_success")]
        public bool ConsolidationSuccess { get; set; }

        /// <summary>
        /// 是否可以重试
        /// </summary>
        [XmlElement("need_retry")]
        public bool NeedRetry { get; set; }

        /// <summary>
        /// 结果信息
        /// </summary>
        [XmlElement("result_msg")]
        public string ResultMsg { get; set; }
    }
}
