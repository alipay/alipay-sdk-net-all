using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayAfxMuseUserBindModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayAfxMuseUserBindModel : AopObject
    {
        /// <summary>
        /// 用户uid，仅做路由，不实际消费
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 用户uid，仅做路由，不实际消费
        /// </summary>
        [XmlElement("user_open_id")]
        public string UserOpenId { get; set; }
    }
}
