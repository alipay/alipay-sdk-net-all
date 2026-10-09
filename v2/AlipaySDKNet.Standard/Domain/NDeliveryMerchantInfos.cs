using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NDeliveryMerchantInfos Data Structure.
    /// </summary>
    [Serializable]
    public class NDeliveryMerchantInfos : AopObject
    {
        /// <summary>
        /// 指定收单账号
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 指定收单账号类型。 枚举值： ·SMID： 间连商户
        /// </summary>
        [XmlElement("merchant_id_type")]
        public string MerchantIdType { get; set; }
    }
}
