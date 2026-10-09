using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceIsresourceGroupquerybyuseridQueryResponse.
    /// </summary>
    public class AlipayIserviceIsresourceGroupquerybyuseridQueryResponse : AopResponse
    {
        /// <summary>
        /// 查询的技能组信息
        /// </summary>
        [XmlArray("biz_data")]
        [XmlArrayItem("open_api_skill_group_info")]
        public List<OpenApiSkillGroupInfo> BizData { get; set; }
    }
}
