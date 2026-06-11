using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceLifeserviceAccountpageGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceLifeserviceAccountpageGetModel : AopObject
    {
        /// <summary>
        /// 核销单id
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 退款对应的次数
        /// </summary>
        [XmlElement("count")]
        public string Count { get; set; }
    }
}
