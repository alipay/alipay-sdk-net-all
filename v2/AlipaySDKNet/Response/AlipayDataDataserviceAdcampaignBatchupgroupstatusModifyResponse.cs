using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdcampaignBatchupgroupstatusModifyResponse.
    /// </summary>
    public class AlipayDataDataserviceAdcampaignBatchupgroupstatusModifyResponse : AopResponse
    {
        /// <summary>
        /// 操作成功计划id集合
        /// </summary>
        [XmlArray("result_list")]
        [XmlArrayItem("number")]
        public List<long> ResultList { get; set; }
    }
}
