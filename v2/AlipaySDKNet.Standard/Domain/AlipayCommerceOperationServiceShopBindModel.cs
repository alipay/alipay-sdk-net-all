using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceOperationServiceShopBindModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceOperationServiceShopBindModel : AopObject
    {
        /// <summary>
        /// 序列化后的业务请求信息,如门店信息
        /// </summary>
        [XmlElement("request_data")]
        public string RequestData { get; set; }

        /// <summary>
        /// 服务code
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
