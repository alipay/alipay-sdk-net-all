using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateTrainStagecaterelationQueryResponse.
    /// </summary>
    public class AlipayCommerceEducateTrainStagecaterelationQueryResponse : AopResponse
    {
        /// <summary>
        /// 学段分组信息
        /// </summary>
        [XmlArray("stage_group_infos")]
        [XmlArrayItem("stage_group_info_v_o")]
        public List<StageGroupInfoVO> StageGroupInfos { get; set; }
    }
}
