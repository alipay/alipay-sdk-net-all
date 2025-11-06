using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZftIndirectRelation Data Structure.
    /// </summary>
    [Serializable]
    public class ZftIndirectRelation : AopObject
    {
        /// <summary>
        /// 申请单处理失败时，通过此此段返回具体的失败理由
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 进件申请单中的二级商户openid
        /// </summary>
        [XmlElement("relation_openid")]
        public string RelationOpenid { get; set; }

        /// <summary>
        /// 进件申请单中的二级商户uid
        /// </summary>
        [XmlElement("relation_uid")]
        public string RelationUid { get; set; }

        /// <summary>
        /// 进件状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 二级商户确认状态
        /// </summary>
        [XmlElement("sub_confirm")]
        public string SubConfirm { get; set; }
    }
}
