using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechOceanbaseTokenValidateQueryResponse.
    /// </summary>
    public class AnttechOceanbaseTokenValidateQueryResponse : AopResponse
    {
        /// <summary>
        /// 身份证认证状态
        /// </summary>
        [XmlElement("id_card_auth_status")]
        public bool IdCardAuthStatus { get; set; }

        /// <summary>
        /// 姓名的最后一个字
        /// </summary>
        [XmlElement("last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// 该用户考试通过的考试等级列表
        /// </summary>
        [XmlArray("passed_certificate_levels")]
        [XmlArrayItem("string")]
        public List<string> PassedCertificateLevels { get; set; }

        /// <summary>
        /// 用户信息状态
        /// </summary>
        [XmlElement("token_auth_status")]
        public bool TokenAuthStatus { get; set; }
    }
}
