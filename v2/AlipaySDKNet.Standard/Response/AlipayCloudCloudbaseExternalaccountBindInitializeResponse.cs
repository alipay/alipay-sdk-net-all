using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseExternalaccountBindInitializeResponse.
    /// </summary>
    public class AlipayCloudCloudbaseExternalaccountBindInitializeResponse : AopResponse
    {
        /// <summary>
        /// 生成的小程序ID
        /// </summary>
        [XmlElement("biz_app_id")]
        public string BizAppId { get; set; }
    }
}
