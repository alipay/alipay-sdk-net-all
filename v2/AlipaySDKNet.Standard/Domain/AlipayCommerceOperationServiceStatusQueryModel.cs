using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceOperationServiceStatusQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceOperationServiceStatusQueryModel : AopObject
    {
        /// <summary>
        /// 业务信息，是序列化字符串，如门店列表信息、商户信息、报名信息等等
        /// </summary>
        [XmlElement("request_data")]
        public string RequestData { get; set; }

        /// <summary>
        /// 服务code，如流量币、高德支付宝音响合作服务码
        /// </summary>
        [XmlElement("service_code")]
        public string ServiceCode { get; set; }

        /// <summary>
        /// 主体id
        /// </summary>
        [XmlElement("subject_id")]
        public string SubjectId { get; set; }

        /// <summary>
        /// 主体类型，枚举值：ALPAY_USER（商户）、SMID（二级商户）、POIMID（门店）、LEADS_ID（leadsId）、BIZ_TID、TAG_ID、SN、EMAIL、PHONE、APP
        /// </summary>
        [XmlElement("subject_type")]
        public string SubjectType { get; set; }
    }
}
