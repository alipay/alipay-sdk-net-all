using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceAnthotlinemngCalldetailBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceAnthotlinemngCalldetailBatchqueryModel : AopObject
    {
        /// <summary>
        /// 业务码 ，用于校验业务权限
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 用作业务权限验签
        /// </summary>
        [XmlElement("biz_sign")]
        public string BizSign { get; set; }

        /// <summary>
        /// 被叫号码过滤
        /// </summary>
        [XmlElement("called_number")]
        public string CalledNumber { get; set; }

        /// <summary>
        /// 按主叫号码过滤。
        /// </summary>
        [XmlElement("calling_number")]
        public string CallingNumber { get; set; }

        /// <summary>
        /// 通话id
        /// </summary>
        [XmlElement("contact_id")]
        public string ContactId { get; set; }

        /// <summary>
        /// 按通话类型过滤。 枚举值： ● Outbound：呼出。 ● Back2Back：双呼。 ● PrivacyDial：加密通话。 ● Internal：内部呼叫。 ● Predictive：预测式外呼。 ● Inbound：呼入。 ● Conference：会议。
        /// </summary>
        [XmlElement("contact_type")]
        public string ContactType { get; set; }

        /// <summary>
        /// 获取的历史数据的终止时间，默认为当前时间，格式为Unix时间戳，单位毫秒。
        /// </summary>
        [XmlElement("end_time")]
        public long EndTime { get; set; }

        /// <summary>
        /// 热线渠道服务实例id
        /// </summary>
        [XmlElement("instance_id")]
        public string InstanceId { get; set; }

        /// <summary>
        /// 分页页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 排序方式，非必填，默认为降序。 枚举值： ● ASC：升序。 ● DESC：降序。
        /// </summary>
        [XmlElement("sort_order")]
        public string SortOrder { get; set; }

        /// <summary>
        /// 获取的历史数据的起始时间，默认为当天的0时，格式为Unix时间戳，单位毫秒。
        /// </summary>
        [XmlElement("start_time")]
        public long StartTime { get; set; }
    }
}
