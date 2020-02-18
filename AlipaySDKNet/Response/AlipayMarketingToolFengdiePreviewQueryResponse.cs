using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingToolFengdiePreviewQueryResponse.
    /// </summary>
    public class AlipayMarketingToolFengdiePreviewQueryResponse : AopResponse
    {
        /// <summary>
        /// 站点页面预览数据返回值
        /// </summary>
        [XmlElement("data")]
        public FengdiePreviewQueryRespModel Data { get; set; }
    }
}
