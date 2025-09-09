using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantGroupDeliveryBatchqueryResponse.
    /// </summary>
    public class AlipayMerchantGroupDeliveryBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 推广计划配置记录列表
        /// </summary>
        [XmlArray("delivery_record_list")]
        [XmlArrayItem("group_delivery_record_v_o")]
        public List<GroupDeliveryRecordVO> DeliveryRecordList { get; set; }

        /// <summary>
        /// 推广计划总条数。取值单位是"条"。
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
