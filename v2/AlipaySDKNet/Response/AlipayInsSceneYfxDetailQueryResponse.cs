using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneYfxDetailQueryResponse.
    /// </summary>
    public class AlipayInsSceneYfxDetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 运费险详情
        /// </summary>
        [XmlElement("yfx_info")]
        public InsOpenYfxInfoDTO YfxInfo { get; set; }
    }
}
