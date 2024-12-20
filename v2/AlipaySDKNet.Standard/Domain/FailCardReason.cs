using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FailCardReason Data Structure.
    /// </summary>
    [Serializable]
    public class FailCardReason : AopObject
    {
        /// <summary>
        /// 卡id
        /// </summary>
        [XmlElement("card_template_id")]
        public string CardTemplateId { get; set; }

        /// <summary>
        /// 发起转移失败原因
        /// </summary>
        [XmlElement("reason")]
        public string Reason { get; set; }
    }
}
