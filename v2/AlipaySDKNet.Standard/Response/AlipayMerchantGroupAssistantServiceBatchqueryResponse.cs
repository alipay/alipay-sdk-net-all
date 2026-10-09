using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantGroupAssistantServiceBatchqueryResponse.
    /// </summary>
    public class AlipayMerchantGroupAssistantServiceBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 小助手快捷服务记录列表
        /// </summary>
        [XmlArray("assistant_record_list")]
        [XmlArrayItem("service_assistant_record_v_o")]
        public List<ServiceAssistantRecordVO> AssistantRecordList { get; set; }

        /// <summary>
        /// 商家配置小助手快捷服务总条数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
