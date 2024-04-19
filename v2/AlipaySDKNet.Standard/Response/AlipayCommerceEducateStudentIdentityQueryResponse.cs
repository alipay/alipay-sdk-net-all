using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateStudentIdentityQueryResponse.
    /// </summary>
    public class AlipayCommerceEducateStudentIdentityQueryResponse : AopResponse
    {
        /// <summary>
        /// 查询用户所在大学，查询商户需要商务层面申请此字段，且支付宝模型中存在此字段才能返回。
        /// </summary>
        [XmlElement("college_name")]
        public string CollegeName { get; set; }

        /// <summary>
        /// 查询用户是否目前是大学生
        /// </summary>
        [XmlElement("college_online_tag")]
        public string CollegeOnlineTag { get; set; }
    }
}
