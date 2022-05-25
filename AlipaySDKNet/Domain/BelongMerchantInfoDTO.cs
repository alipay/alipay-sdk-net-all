using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BelongMerchantInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class BelongMerchantInfoDTO : AopObject
    {
        /// <summary>
        /// 合作业务类型,默认为ISV_FOR_MERCHANT 枚举值: ISV_FOR_MERCHANT 服务商代运营模式
        /// </summary>
        [XmlElement("business_type")]
        public string BusinessType { get; set; }

        /// <summary>
        /// 商户PID;限制:1、服务商代运营模式必传
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }
    }
}
