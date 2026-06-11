using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KnxAuthDetail Data Structure.
    /// </summary>
    [Serializable]
    public class KnxAuthDetail : AopObject
    {
        /// <summary>
        /// 用户授权内容
        /// </summary>
        [XmlElement("auth_content")]
        public string AuthContent { get; set; }

        /// <summary>
        /// 授权用户
        /// </summary>
        [XmlElement("auth_name")]
        public string AuthName { get; set; }

        /// <summary>
        /// 用户授权获取档案成员时间
        /// </summary>
        [XmlElement("auth_time")]
        public string AuthTime { get; set; }
    }
}
