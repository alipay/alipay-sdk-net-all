using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceOperationUserFeatureConsultResponse.
    /// </summary>
    public class AlipayCommerceOperationUserFeatureConsultResponse : AopResponse
    {
        /// <summary>
        /// biz_scene
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 咨询结果
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
