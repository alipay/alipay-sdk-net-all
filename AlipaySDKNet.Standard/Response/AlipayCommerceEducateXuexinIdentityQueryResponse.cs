using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateXuexinIdentityQueryResponse.
    /// </summary>
    public class AlipayCommerceEducateXuexinIdentityQueryResponse : AopResponse
    {
        /// <summary>
        /// 0表示非学生,1表示学生
        /// </summary>
        [XmlElement("college_online_tag")]
        public string CollegeOnlineTag { get; set; }

        /// <summary>
        /// 预计毕业时间 yyyyMM
        /// </summary>
        [XmlElement("graduate_time")]
        public string GraduateTime { get; set; }
    }
}
