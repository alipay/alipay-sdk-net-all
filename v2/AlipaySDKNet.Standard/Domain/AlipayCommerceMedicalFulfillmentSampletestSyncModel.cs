using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalFulfillmentSampletestSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalFulfillmentSampletestSyncModel : AopObject
    {
        /// <summary>
        /// 履约单号
        /// </summary>
        [XmlElement("fulfillment_id")]
        public string FulfillmentId { get; set; }

        /// <summary>
        /// 关联订单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 事件数据
        /// </summary>
        [XmlElement("sample_status")]
        public string SampleStatus { get; set; }

        /// <summary>
        /// 样本状态变更时间，格式：yyyy-MM-dd hh:mm:ss
        /// </summary>
        [XmlElement("sample_status_time")]
        public string SampleStatusTime { get; set; }

        /// <summary>
        /// 履约类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
