using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MakeCallRequest Data Structure.
    /// </summary>
    [Serializable]
    public class MakeCallRequest : AopObject
    {
        /// <summary>
        /// 被叫电话号码
        /// </summary>
        [XmlElement("callee")]
        public string Callee { get; set; }

        /// <summary>
        /// 脱敏后的被叫电话号码
        /// </summary>
        [XmlElement("mask_callee")]
        public string MaskCallee { get; set; }

        /// <summary>
        /// 坐席用户ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
