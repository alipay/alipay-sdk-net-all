using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserDtbankcustAccountQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserDtbankcustAccountQueryModel : AopObject
    {
        /// <summary>
        /// 用户登录账号ID，logon_id，phone_id不能同时为空，二选一
        /// </summary>
        [XmlElement("logon_id")]
        public string LogonId { get; set; }

        /// <summary>
        /// 用户手机号，logon_id，phone_id不能同时为空，二选一
        /// </summary>
        [XmlElement("phone_id")]
        public string PhoneId { get; set; }
    }
}
