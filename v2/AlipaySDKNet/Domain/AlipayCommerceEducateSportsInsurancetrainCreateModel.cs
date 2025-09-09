using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateSportsInsurancetrainCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateSportsInsurancetrainCreateModel : AopObject
    {
        /// <summary>
        /// 广告资源位ID
        /// </summary>
        [XmlElement("resource_id")]
        public string ResourceId { get; set; }

        /// <summary>
        /// 回调加密参数
        /// </summary>
        [XmlElement("security_data")]
        public string SecurityData { get; set; }
    }
}
