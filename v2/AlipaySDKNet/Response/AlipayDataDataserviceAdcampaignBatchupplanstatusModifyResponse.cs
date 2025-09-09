using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdcampaignBatchupplanstatusModifyResponse.
    /// </summary>
    public class AlipayDataDataserviceAdcampaignBatchupplanstatusModifyResponse : AopResponse
    {
        /// <summary>
        /// 操作成功计划id集合
        /// </summary>
        [XmlArray("result_list")]
        [XmlArrayItem("number")]
        public List<long> ResultList { get; set; }
    }
}
