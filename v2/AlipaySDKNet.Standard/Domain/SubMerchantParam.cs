using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SubMerchantParam Data Structure.
    /// </summary>
    [Serializable]
    public class SubMerchantParam : AopObject
    {
        /// <summary>
        /// 选填。此参数用于传入子商户信息，目前商户代扣、海外代扣、淘旅行信用住产品支持传入该参数(在销售方案中“是否允许自定义子商户信息”需要选是)
        /// </summary>
        [XmlElement("sub_merchant_id")]
        public string SubMerchantId { get; set; }

        /// <summary>
        /// 子商户的商户名称
        /// </summary>
        [XmlElement("sub_merchant_name")]
        public string SubMerchantName { get; set; }

        /// <summary>
        /// 子商户的服务描述
        /// </summary>
        [XmlElement("sub_merchant_service_description")]
        public string SubMerchantServiceDescription { get; set; }

        /// <summary>
        /// 子商户的服务名称
        /// </summary>
        [XmlElement("sub_merchant_service_name")]
        public string SubMerchantServiceName { get; set; }
    }
}
