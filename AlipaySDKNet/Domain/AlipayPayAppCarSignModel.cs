using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPayAppCarSignModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPayAppCarSignModel : AopObject
    {
        /// <summary>
        /// 当前登录的用户ID
        /// </summary>
        [XmlElement("current_user_id")]
        public string CurrentUserId { get; set; }
    }
}
