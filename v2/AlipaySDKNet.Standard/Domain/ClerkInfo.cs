using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ClerkInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ClerkInfo : AopObject
    {
        /// <summary>
        /// 开票人姓名
        /// </summary>
        [XmlElement("clerk_name")]
        public string ClerkName { get; set; }

        /// <summary>
        /// 开票人身份标识
        /// </summary>
        [XmlElement("clerk_no")]
        public string ClerkNo { get; set; }

        /// <summary>
        /// 开票员确认状态
        /// </summary>
        [XmlElement("confirm_status")]
        public string ConfirmStatus { get; set; }
    }
}
