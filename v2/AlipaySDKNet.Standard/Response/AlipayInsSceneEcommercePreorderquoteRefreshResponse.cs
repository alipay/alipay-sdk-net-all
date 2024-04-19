using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneEcommercePreorderquoteRefreshResponse.
    /// </summary>
    public class AlipayInsSceneEcommercePreorderquoteRefreshResponse : AopResponse
    {
        /// <summary>
        /// 更新后的预下单数据
        /// </summary>
        [XmlElement("pre_order")]
        public InsPreOrderDTO PreOrder { get; set; }
    }
}
