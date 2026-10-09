using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SubMerchantModifyDTO Data Structure.
    /// </summary>
    [Serializable]
    public class SubMerchantModifyDTO : AopObject
    {
        /// <summary>
        /// 平台商模式，派单后真实的二级商户id
        /// </summary>
        [XmlElement("real_merchant_id")]
        public string RealMerchantId { get; set; }
    }
}
