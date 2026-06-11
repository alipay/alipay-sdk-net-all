using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalArchiveEmpowerSaveResponse.
    /// </summary>
    public class AlipayCommerceMedicalArchiveEmpowerSaveResponse : AopResponse
    {
        /// <summary>
        /// 认证令牌
        /// </summary>
        [XmlElement("access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// 档案成员h5页面url
        /// </summary>
        [XmlElement("archives_member_url")]
        public string ArchivesMemberUrl { get; set; }

        /// <summary>
        /// 成员是否有效
        /// </summary>
        [XmlElement("member_validate")]
        public string MemberValidate { get; set; }

        /// <summary>
        /// access_token有效期
        /// </summary>
        [XmlElement("token_validity")]
        public string TokenValidity { get; set; }
    }
}
