using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateSceneFacegroupQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateSceneFacegroupQueryModel : AopObject
    {
        /// <summary>
        /// 支付宝学校内标
        /// </summary>
        [XmlElement("alipay_school_id")]
        public string AlipaySchoolId { get; set; }
    }
}
