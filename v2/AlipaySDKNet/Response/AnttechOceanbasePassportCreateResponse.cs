using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechOceanbasePassportCreateResponse.
    /// </summary>
    public class AnttechOceanbasePassportCreateResponse : AopResponse
    {
        /// <summary>
        /// 实体角色id
        /// </summary>
        [XmlElement("entity_role_id")]
        public string EntityRoleId { get; set; }

        /// <summary>
        /// 用户通行证id
        /// </summary>
        [XmlElement("passport_id")]
        public string PassportId { get; set; }
    }
}
