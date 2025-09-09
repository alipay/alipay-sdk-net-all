using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudpromoMessageDeliveryQueryResponse.
    /// </summary>
    public class AlipayCloudCloudpromoMessageDeliveryQueryResponse : AopResponse
    {
        /// <summary>
        /// 触达记录结果详情
        /// </summary>
        [XmlArray("call_record_details")]
        [XmlArrayItem("call_record_detail")]
        public List<CallRecordDetail> CallRecordDetails { get; set; }

        /// <summary>
        /// 智能触达时记录ID，用于查询触达结果
        /// </summary>
        [XmlElement("record_id")]
        public string RecordId { get; set; }

        /// <summary>
        /// 记录状态：INIT-初始化,PROCESSING-外呼进行中,FINISHED-外呼完成,FAILED-外呼失败
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
