using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantGroupGroupinfoBatchqueryResponse.
    /// </summary>
    public class AlipayMerchantGroupGroupinfoBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 群组列表
        /// </summary>
        [XmlArray("group_list")]
        [XmlArrayItem("group_detail_v_o")]
        public List<GroupDetailVO> GroupList { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 查询结果总数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
