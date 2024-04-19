using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GFAOpenAPIQueryRequest Data Structure.
    /// </summary>
    [Serializable]
    public class GFAOpenAPIQueryRequest : AopObject
    {
        /// <summary>
        /// 业财受理单id
        /// </summary>
        [XmlElement("acceptance_id")]
        public string AcceptanceId { get; set; }

        /// <summary>
        /// 两码-业务事件码
        /// </summary>
        [XmlElement("biz_ev_code")]
        public string BizEvCode { get; set; }

        /// <summary>
        /// 业务流水号
        /// </summary>
        [XmlElement("out_business_no")]
        public string OutBusinessNo { get; set; }

        /// <summary>
        /// 业务唯一标识
        /// </summary>
        [XmlElement("service_type")]
        public string ServiceType { get; set; }

        /// <summary>
        /// 业务流水子单号
        /// </summary>
        [XmlElement("sub_out_business_no")]
        public string SubOutBusinessNo { get; set; }

        /// <summary>
        /// 是否用 biz_ev_code 字段筛选
        /// </summary>
        [XmlElement("use_biz_ev_code")]
        public bool UseBizEvCode { get; set; }

        /// <summary>
        /// 是否使用 sub_out_business_no 字段做筛选
        /// </summary>
        [XmlElement("use_sub_out_business_no")]
        public bool UseSubOutBusinessNo { get; set; }
    }
}
