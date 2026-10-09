using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPayPosterAppQueryResponse.
    /// </summary>
    public class AlipayPayPosterAppQueryResponse : AopResponse
    {
        /// <summary>
        /// 立减进度条渲染结果
        /// </summary>
        [XmlElement("data")]
        public NfcPointRefreshData Data { get; set; }
    }
}
