using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustryIntentionBatchqueryResponse.
    /// </summary>
    public class AlipayEbppIndustryIntentionBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 意图信息列表
        /// </summary>
        [XmlArray("intention_list")]
        [XmlArrayItem("intention_base_info")]
        public List<IntentionBaseInfo> IntentionList { get; set; }
    }
}
