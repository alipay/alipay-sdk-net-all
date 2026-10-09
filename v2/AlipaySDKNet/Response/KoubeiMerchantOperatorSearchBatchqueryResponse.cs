using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiMerchantOperatorSearchBatchqueryResponse.
    /// </summary>
    public class KoubeiMerchantOperatorSearchBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 当前页码
        /// </summary>
        [XmlElement("current_page")]
        public long CurrentPage { get; set; }

        /// <summary>
        /// 操作员信息列表
        /// </summary>
        [XmlArray("operator_info_models")]
        [XmlArrayItem("operator_info_model")]
        public List<OperatorInfoModel> OperatorInfoModels { get; set; }

        /// <summary>
        /// 总数据量
        /// </summary>
        [XmlElement("total_items")]
        public long TotalItems { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [XmlElement("total_pages")]
        public long TotalPages { get; set; }
    }
}
