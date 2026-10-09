using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantIsvhelpEntryQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantIsvhelpEntryQueryModel : AopObject
    {
        /// <summary>
        /// 服务商自定义的申请编号，每个申请编号唯一对应一个申请单，需在服务商下唯一。只能用数字、字母或下划线组成
        /// </summary>
        [XmlElement("external_id")]
        public string ExternalId { get; set; }
    }
}
