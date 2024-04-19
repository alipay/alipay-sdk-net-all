using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniIsvFastregisterCreateResponse.
    /// </summary>
    public class AlipayOpenMiniIsvFastregisterCreateResponse : AopResponse
    {
        /// <summary>
        /// 授权确认跳转url
        /// </summary>
        [XmlElement("authorize_url")]
        public string AuthorizeUrl { get; set; }

        /// <summary>
        /// 代创建试用小程序单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }
    }
}
