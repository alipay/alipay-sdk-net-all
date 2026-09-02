using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneInshealthserviceprodHealthmallitemCreateResponse.
    /// </summary>
    public class AlipayInsSceneInshealthserviceprodHealthmallitemCreateResponse : AopResponse
    {
        /// <summary>
        /// 商品信息
        /// </summary>
        [XmlElement("item")]
        public ExternalItemInfo Item { get; set; }
    }
}
