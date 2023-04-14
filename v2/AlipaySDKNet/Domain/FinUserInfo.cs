using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FinUserInfo Data Structure.
    /// </summary>
    [Serializable]
    public class FinUserInfo : AopObject
    {
        /// <summary>
        /// 蚂蚁中的用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
