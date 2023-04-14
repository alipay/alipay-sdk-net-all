using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbasePassinfoLogininfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbasePassinfoLogininfoQueryModel : AopObject
    {
        /// <summary>
        /// 通行认证令牌
        /// </summary>
        [XmlElement("ob_auth_token")]
        public string ObAuthToken { get; set; }

        /// <summary>
        /// 是否续期标记。设置true续期、设置false不续期。默认不续期。
        /// </summary>
        [XmlElement("renew")]
        public bool Renew { get; set; }

        /// <summary>
        /// 自然实体类型。MEMBER（个人账号）、MASTER（企业主账号）
        /// </summary>
        [XmlElement("role_type")]
        public string RoleType { get; set; }
    }
}
