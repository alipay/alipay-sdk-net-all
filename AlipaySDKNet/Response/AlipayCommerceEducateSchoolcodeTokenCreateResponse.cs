using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateSchoolcodeTokenCreateResponse.
    /// </summary>
    public class AlipayCommerceEducateSchoolcodeTokenCreateResponse : AopResponse
    {
        /// <summary>
        /// 学生信息凭证，在用户信息授权时使用，作为授权url中state的参数值，创建token接口返回
        /// </summary>
        [XmlElement("school_code_token")]
        public string SchoolCodeToken { get; set; }
    }
}
