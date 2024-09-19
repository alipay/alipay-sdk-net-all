using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMerchantcardConfigModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMerchantcardConfigModifyModel : AopObject
    {
        /// <summary>
        /// 安心付商户配置
        /// </summary>
        [XmlElement("axf_merchant_config")]
        public AxfMerchantConfig AxfMerchantConfig { get; set; }
    }
}
