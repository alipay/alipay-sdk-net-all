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
        /// 申请单id。通过 ant.merchant.expand.indirect.zft.create(二级商户创建)接口返回。与 external_id 二选一必填，若同时传入将以 order_id 为准进行查询。
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }
    }
}
