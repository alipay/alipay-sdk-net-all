using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniMorphoApplistBatchqueryResponse.
    /// </summary>
    public class AlipayOpenMiniMorphoApplistBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 应用列表
        /// </summary>
        [XmlArray("data_list")]
        [XmlArrayItem("morpho_app_item")]
        public List<MorphoAppItem> DataList { get; set; }

        /// <summary>
        /// 批量查询分页信息
        /// </summary>
        [XmlElement("paginator")]
        public MorphoPaginator Paginator { get; set; }
    }
}
