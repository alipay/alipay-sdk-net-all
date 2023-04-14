using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AccountBaseInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class AccountBaseInfoVO : AopObject
    {
        /// <summary>
        /// 账户号
        /// </summary>
        [XmlElement("act_no")]
        public string ActNo { get; set; }

        /// <summary>
        /// 账户状态:A-开户成功，N-未开户，F-账户异常
        /// </summary>
        [XmlElement("act_status")]
        public string ActStatus { get; set; }

        /// <summary>
        /// 账户类型
        /// </summary>
        [XmlElement("act_type")]
        public string ActType { get; set; }
    }
}
