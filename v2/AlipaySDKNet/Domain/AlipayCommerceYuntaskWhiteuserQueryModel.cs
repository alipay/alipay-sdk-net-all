using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceYuntaskWhiteuserQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceYuntaskWhiteuserQueryModel : AopObject
    {
        /// <summary>
        /// 第几页，分页使用
        /// </summary>
        [XmlElement("page")]
        public long Page { get; set; }

        /// <summary>
        /// 每页数量，分页使用，单位个
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 超导任务模版id，在超导SaaS后台针对任务点击操作时，将对应的任务id传过来
        /// </summary>
        [XmlElement("task_template_id")]
        public string TaskTemplateId { get; set; }
    }
}
