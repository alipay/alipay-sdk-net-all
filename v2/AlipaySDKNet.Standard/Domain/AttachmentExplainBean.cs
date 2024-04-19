using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AttachmentExplainBean Data Structure.
    /// </summary>
    [Serializable]
    public class AttachmentExplainBean : AopObject
    {
        /// <summary>
        /// 页面展示的任务描（collect_attachement值为true时必填）
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 附件列表，用于定义每个附件code的描述及页面展示顺序
        /// </summary>
        [XmlArray("details")]
        [XmlArrayItem("detail_bean")]
        public List<DetailBean> Details { get; set; }

        /// <summary>
        /// 页面展示的任务标题（collect_attachement值为true时必填）
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
