using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ServiceRecordDetailVO Data Structure.
    /// </summary>
    [Serializable]
    public class ServiceRecordDetailVO : AopObject
    {
        /// <summary>
        /// 用户身份证号
        /// </summary>
        [XmlElement("customer_cert_no")]
        public string CustomerCertNo { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [XmlElement("customer_id")]
        public string CustomerId { get; set; }

        /// <summary>
        /// 用户呼入手机号
        /// </summary>
        [XmlElement("customer_phone")]
        public string CustomerPhone { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 小计信息
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 外部单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 服务唯一ID
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 主键ID
        /// </summary>
        [XmlElement("service_record_id")]
        public string ServiceRecordId { get; set; }

        /// <summary>
        /// 服务来源
        /// </summary>
        [XmlElement("service_source")]
        public string ServiceSource { get; set; }

        /// <summary>
        /// 服务开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
