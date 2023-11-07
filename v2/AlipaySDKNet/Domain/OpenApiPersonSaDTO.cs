using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenApiPersonSaDTO Data Structure.
    /// </summary>
    [Serializable]
    public class OpenApiPersonSaDTO : AopObject
    {
        /// <summary>
        /// 花名
        /// </summary>
        [XmlElement("nick_name")]
        public string NickName { get; set; }

        /// <summary>
        /// 人员真名
        /// </summary>
        [XmlElement("real_name")]
        public string RealName { get; set; }

        /// <summary>
        /// 用户角色
        /// </summary>
        [XmlElement("role_type")]
        public string RoleType { get; set; }

        /// <summary>
        /// 工号
        /// </summary>
        [XmlElement("work_no")]
        public string WorkNo { get; set; }
    }
}
