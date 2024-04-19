using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LoginRecordDTO Data Structure.
    /// </summary>
    [Serializable]
    public class LoginRecordDTO : AopObject
    {
        /// <summary>
        /// 退出时间
        /// </summary>
        [XmlElement("exit_time")]
        public string ExitTime { get; set; }

        /// <summary>
        /// 登录时间
        /// </summary>
        [XmlElement("login_time")]
        public string LoginTime { get; set; }

        /// <summary>
        /// 通行证id
        /// </summary>
        [XmlElement("passport_id")]
        public string PassportId { get; set; }
    }
}
