using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserAuthenticationMatchModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserAuthenticationMatchModel : AopObject
    {
        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id_1")]
        public string UserId1 { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id_2")]
        public string UserId2 { get; set; }
    }
}
