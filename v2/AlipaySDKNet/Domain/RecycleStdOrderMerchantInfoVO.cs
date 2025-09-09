using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecycleStdOrderMerchantInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class RecycleStdOrderMerchantInfoVO : AopObject
    {
        /// <summary>
        /// 商户图标
        /// </summary>
        [XmlElement("merchant_logo")]
        public string MerchantLogo { get; set; }

        /// <summary>
        /// 商户名称
        /// </summary>
        [XmlElement("merchant_name")]
        public string MerchantName { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        [XmlElement("merchant_phone")]
        public string MerchantPhone { get; set; }
    }
}
