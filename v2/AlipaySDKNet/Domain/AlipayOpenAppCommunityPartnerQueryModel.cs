using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppCommunityPartnerQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppCommunityPartnerQueryModel : AopObject
    {
        /// <summary>
        /// 关系类型
        /// </summary>
        [XmlElement("rela_type")]
        public string RelaType { get; set; }

        /// <summary>
        /// 源对象id
        /// </summary>
        [XmlElement("source_id")]
        public string SourceId { get; set; }

        /// <summary>
        /// 对象类型id（例如支付宝user_id）
        /// </summary>
        [XmlElement("target_id")]
        public string TargetId { get; set; }
    }
}
