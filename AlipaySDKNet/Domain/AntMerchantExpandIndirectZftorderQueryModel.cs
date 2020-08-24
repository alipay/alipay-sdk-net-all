using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandIndirectZftorderQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandIndirectZftorderQueryModel : AopObject
    {
        /// <summary>
        /// 进件申请时的外部商户id，与order_id二选一必填
        /// </summary>
        [XmlElement("external_id")]
        public string ExternalId { get; set; }

        /// <summary>
        /// 进件接口返回的申请单id。与external_id二选一必填。若都传以order_id的查询为准。
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }
    }
}
