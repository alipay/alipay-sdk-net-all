using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OutOrderUserInfo Data Structure.
    /// </summary>
    [Serializable]
    public class OutOrderUserInfo : AopObject
    {
        /// <summary>
        /// 用户姓名
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }

        /// <summary>
        /// 用户手机
        /// </summary>
        [XmlElement("user_phone")]
        public string UserPhone { get; set; }
    }
}
