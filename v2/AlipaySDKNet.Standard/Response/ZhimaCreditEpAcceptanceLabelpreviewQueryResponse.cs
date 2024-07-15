using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpAcceptanceLabelpreviewQueryResponse.
    /// </summary>
    public class ZhimaCreditEpAcceptanceLabelpreviewQueryResponse : AopResponse
    {
        /// <summary>
        /// 是否授权标签信用服务
        /// </summary>
        [XmlElement("has_authed")]
        public bool HasAuthed { get; set; }

        /// <summary>
        /// 企业名下是否有正向标签
        /// </summary>
        [XmlElement("has_data")]
        public bool HasData { get; set; }

        /// <summary>
        /// 企业标签内容模型
        /// </summary>
        [XmlArray("label_content")]
        [XmlArrayItem("ep_label_content")]
        public List<EpLabelContent> LabelContent { get; set; }

        /// <summary>
        /// 企业名下预计标签数量(个)
        /// </summary>
        [XmlElement("label_count")]
        public long LabelCount { get; set; }

        /// <summary>
        /// 标签展示类型
        /// </summary>
        [XmlElement("label_show_type")]
        public string LabelShowType { get; set; }

        /// <summary>
        /// 企业名下标签待获取数量(个)
        /// </summary>
        [XmlElement("label_to_obtain_count")]
        public long LabelToObtainCount { get; set; }
    }
}
