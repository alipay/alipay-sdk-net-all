using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DeliveryTargetRule Data Structure.
    /// </summary>
    [Serializable]
    public class DeliveryTargetRule : AopObject
    {
        /// <summary>
        /// 曝光商户选取列表。 说明：需要传入您期望曝光的商户的商户号，传入为空时默认使用投放优惠券活动的适用范围。 限制：曝光商户号需与投放归属商户号相同，或传入有跨主体授权关系的商户号或有弱绑定关系的M3账号
        /// </summary>
        [XmlArray("delivery_merchant_infos")]
        [XmlArrayItem("delivery_merchant_info")]
        public List<DeliveryMerchantInfo> DeliveryMerchantInfos { get; set; }
    }
}
