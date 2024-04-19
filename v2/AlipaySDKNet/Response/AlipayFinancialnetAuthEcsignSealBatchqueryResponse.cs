using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFinancialnetAuthEcsignSealBatchqueryResponse.
    /// </summary>
    public class AlipayFinancialnetAuthEcsignSealBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 页，默认1，必须要大于0。
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 页面大小，默认200。
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 用印列表
        /// </summary>
        [XmlArray("seal_list")]
        [XmlArrayItem("ecsign_seal_open_v_o")]
        public List<EcsignSealOpenVO> SealList { get; set; }

        /// <summary>
        /// 列表记录总数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
