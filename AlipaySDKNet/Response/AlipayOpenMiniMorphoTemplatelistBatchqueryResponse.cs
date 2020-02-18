using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniMorphoTemplatelistBatchqueryResponse.
    /// </summary>
    public class AlipayOpenMiniMorphoTemplatelistBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 模板列表
        /// </summary>
        [XmlArray("data_list")]
        [XmlArrayItem("morpho_template_item")]
        public List<MorphoTemplateItem> DataList { get; set; }

        /// <summary>
        /// 分页信息
        /// </summary>
        [XmlElement("paginator")]
        public MorphoPaginator Paginator { get; set; }
    }
}
