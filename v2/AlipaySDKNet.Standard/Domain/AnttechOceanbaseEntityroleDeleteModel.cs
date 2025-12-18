using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseEntityroleDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseEntityroleDeleteModel : AopObject
    {
        /// <summary>
        /// OceanBase Cloud的用户Id，可从个人中心获取
        /// </summary>
        [XmlElement("passport_id")]
        public string PassportId { get; set; }

        /// <summary>
        /// 见枚举类型EntityRoleTypeEnum，目前只支持删除阿里云的
        /// </summary>
        [XmlElement("role_type")]
        public string RoleType { get; set; }
    }
}
