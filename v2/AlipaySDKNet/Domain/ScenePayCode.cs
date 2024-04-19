using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ScenePayCode Data Structure.
    /// </summary>
    [Serializable]
    public class ScenePayCode : AopObject
    {
        /// <summary>
        /// 通过场景支付凭证，交换出的目标码值
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 通过原始的场景支付码值，交换出的目标码值类型
        /// </summary>
        [XmlElement("code_type")]
        public string CodeType { get; set; }

        /// <summary>
        /// 码值有效期结束时间
        /// </summary>
        [XmlElement("expire_date")]
        public string ExpireDate { get; set; }

        /// <summary>
        /// 码值有效期的开始时间
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }
    }
}
