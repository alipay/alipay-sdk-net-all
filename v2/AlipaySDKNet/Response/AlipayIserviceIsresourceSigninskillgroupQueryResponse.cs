using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceIsresourceSigninskillgroupQueryResponse.
    /// </summary>
    public class AlipayIserviceIsresourceSigninskillgroupQueryResponse : AopResponse
    {
        /// <summary>
        /// 签入技能组查询响应
        /// </summary>
        [XmlArray("biz_data")]
        [XmlArrayItem("open_api_skill_group_info")]
        public List<OpenApiSkillGroupInfo> BizData { get; set; }
    }
}
