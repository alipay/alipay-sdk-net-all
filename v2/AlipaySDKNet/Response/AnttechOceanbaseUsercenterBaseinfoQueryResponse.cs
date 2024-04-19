using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechOceanbaseUsercenterBaseinfoQueryResponse.
    /// </summary>
    public class AnttechOceanbaseUsercenterBaseinfoQueryResponse : AopResponse
    {
        /// <summary>
        /// MEMBER=会员，HUAWEIMP_BUYER=华为云MP买家
        /// </summary>
        [XmlArray("entity_role_type_list")]
        [XmlArrayItem("string")]
        public List<string> EntityRoleTypeList { get; set; }

        /// <summary>
        /// 通行证id
        /// </summary>
        [XmlElement("passport_id")]
        public string PassportId { get; set; }
    }
}
