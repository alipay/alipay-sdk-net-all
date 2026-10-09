using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AoiUser Data Structure.
    /// </summary>
    [Serializable]
    public class AoiUser : AopObject
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 用户名称
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }
    }
}
