using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantGroupGroupinstanceinfoBatchqueryResponse.
    /// </summary>
    public class AlipayMerchantGroupGroupinstanceinfoBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 群列表
        /// </summary>
        [XmlArray("group_instance_list")]
        [XmlArrayItem("group_instance_info_v_o")]
        public List<GroupInstanceInfoVO> GroupInstanceList { get; set; }

        /// <summary>
        /// 分页页号
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
