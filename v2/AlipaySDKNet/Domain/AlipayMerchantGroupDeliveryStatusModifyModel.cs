using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantGroupDeliveryStatusModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantGroupDeliveryStatusModifyModel : AopObject
    {
        /// <summary>
        /// 推广计划id
        /// </summary>
        [XmlElement("delivery_id")]
        public string DeliveryId { get; set; }

        /// <summary>
        /// 推广计划更新状态，对指定推广delivery_id进行变更。操作说明：1、状态VALID启用时，只能进行INVALID停用操作 2、状态INVALID停用时，只能进行VALID启用操作。状态流转如下：VALID启用->INVALID停用;INVALID停用->VALID启用。
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
