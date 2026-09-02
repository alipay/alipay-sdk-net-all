using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneInshealthserviceprodMallitemModifyResponse.
    /// </summary>
    public class AlipayInsSceneInshealthserviceprodMallitemModifyResponse : AopResponse
    {
        /// <summary>
        /// 商品信息
        /// </summary>
        [XmlElement("item")]
        public ExternalItemInfo Item { get; set; }
    }
}
