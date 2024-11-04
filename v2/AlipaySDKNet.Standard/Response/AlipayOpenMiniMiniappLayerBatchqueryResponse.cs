using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniMiniappLayerBatchqueryResponse.
    /// </summary>
    public class AlipayOpenMiniMiniappLayerBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 有礼投放活动列表
        /// </summary>
        [XmlArray("delivery_result_list")]
        [XmlArrayItem("delivery_result")]
        public List<DeliveryResult> DeliveryResultList { get; set; }

        /// <summary>
        /// 第几页
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页数据10条
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总共多少条数据
        /// </summary>
        [XmlElement("total_size")]
        public long TotalSize { get; set; }
    }
}
