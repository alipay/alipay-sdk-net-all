using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseMiniappAppCreateResponse.
    /// </summary>
    public class AlipayCloudCloudbaseMiniappAppCreateResponse : AopResponse
    {
        /// <summary>
        /// 生成的应用ID
        /// </summary>
        [XmlElement("biz_app_id")]
        public string BizAppId { get; set; }
    }
}
