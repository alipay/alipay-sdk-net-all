using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceSportsGamesFriendlistQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceSportsGamesFriendlistQueryModel : AopObject
    {
        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
