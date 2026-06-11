using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityDataTesthuiduQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityDataTesthuiduQueryModel : AopObject
    {
        /// <summary>
        /// 年龄
        /// </summary>
        [XmlElement("age")]
        public string Age { get; set; }

        /// <summary>
        /// 用户信息
        /// </summary>
        [XmlElement("user_info")]
        public HuiDuTest UserInfo { get; set; }
    }
}
