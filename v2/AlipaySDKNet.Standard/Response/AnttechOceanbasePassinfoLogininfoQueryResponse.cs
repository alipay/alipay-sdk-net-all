using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechOceanbasePassinfoLogininfoQueryResponse.
    /// </summary>
    public class AnttechOceanbasePassinfoLogininfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 自然实体id。当获取个人信息时为空，当获取企业信息时是企业id。
        /// </summary>
        [XmlElement("entity_id")]
        public string EntityId { get; set; }

        /// <summary>
        /// 通行证ID
        /// </summary>
        [XmlElement("passport_id")]
        public string PassportId { get; set; }

        /// <summary>
        /// 自然实体类型。MEMBER（个人账号）、MASTER（企业主账号）
        /// </summary>
        [XmlElement("role_type")]
        public string RoleType { get; set; }
    }
}
