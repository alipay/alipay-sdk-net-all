using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceOperationUserFeatureConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceOperationUserFeatureConsultModel : AopObject
    {
        /// <summary>
        /// 业务场景
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }
    }
}
