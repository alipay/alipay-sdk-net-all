using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceIsresourceGroupquerybygroupidQueryResponse.
    /// </summary>
    public class AlipayIserviceIsresourceGroupquerybygroupidQueryResponse : AopResponse
    {
        /// <summary>
        /// 技能组信息
        /// </summary>
        [XmlElement("biz_data")]
        public OpenApiSkillGroupInfo BizData { get; set; }
    }
}
