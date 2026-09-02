using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SystemPermissionPrivacyFields Data Structure.
    /// </summary>
    [Serializable]
    public class SystemPermissionPrivacyFields : AopObject
    {
        /// <summary>
        /// 字段的code
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 和code匹配传入，具体匹配关系及枚举请参见文档
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 向用户说明获取该端权限的必要性
        /// </summary>
        [XmlElement("purpose")]
        public string Purpose { get; set; }
    }
}
