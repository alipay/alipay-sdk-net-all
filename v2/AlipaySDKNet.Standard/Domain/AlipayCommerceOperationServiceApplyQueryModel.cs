using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceOperationServiceApplyQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceOperationServiceApplyQueryModel : AopObject
    {
        /// <summary>
        /// 报名记录id
        /// </summary>
        [XmlElement("apply_record_id")]
        public string ApplyRecordId { get; set; }

        /// <summary>
        /// 服务code，如流量币、高德支付宝音响合作服务码
        /// </summary>
        [XmlElement("service_code")]
        public string ServiceCode { get; set; }
    }
}
