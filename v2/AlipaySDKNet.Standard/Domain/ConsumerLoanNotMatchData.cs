using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ConsumerLoanNotMatchData Data Structure.
    /// </summary>
    [Serializable]
    public class ConsumerLoanNotMatchData : AopObject
    {
        /// <summary>
        /// 未能匹配上的用户姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 未能匹配上的用户手机号
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }
    }
}
