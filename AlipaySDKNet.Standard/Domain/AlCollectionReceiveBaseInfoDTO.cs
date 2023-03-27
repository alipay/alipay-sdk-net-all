using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlCollectionReceiveBaseInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class AlCollectionReceiveBaseInfoDTO : AopObject
    {
        /// <summary>
        /// 法催需求标题
        /// </summary>
        [XmlElement("collection_title")]
        public string CollectionTitle { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 法催录入时的工单ID
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 系统来源
        /// </summary>
        [XmlElement("source_sys")]
        public string SourceSys { get; set; }

        /// <summary>
        /// 函件模板ID(上游系统首次发函模板)
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }
    }
}
