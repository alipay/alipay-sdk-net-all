using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserMemberSceneQueryResponse.
    /// </summary>
    public class AlipayUserMemberSceneQueryResponse : AopResponse
    {
        /// <summary>
        /// 用户在指定场景下的状态信息结果  在COLLEGE_LIFE场景下：0表示和大学生用户人群的兴趣喜好不匹配，1表示和大学生用户人群的兴趣喜好匹配
        /// </summary>
        [XmlElement("state")]
        public long State { get; set; }
    }
}
