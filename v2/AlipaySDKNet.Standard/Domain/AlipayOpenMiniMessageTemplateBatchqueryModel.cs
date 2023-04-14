using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniMessageTemplateBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniMessageTemplateBatchqueryModel : AopObject
    {
        /// <summary>
        /// 消息类型，目前仅支持查询订阅消息，biz_type:sub_msg
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 分页页号
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页大小，目前上限为10
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 子版状态
        /// </summary>
        [XmlArray("status_list")]
        [XmlArrayItem("string")]
        public List<string> StatusList { get; set; }
    }
}
