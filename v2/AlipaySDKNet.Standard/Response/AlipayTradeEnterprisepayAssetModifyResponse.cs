using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeEnterprisepayAssetModifyResponse.
    /// </summary>
    public class AlipayTradeEnterprisepayAssetModifyResponse : AopResponse
    {
        /// <summary>
        /// 因公付资产切换操作跳转链接
        /// </summary>
        [XmlElement("redirect_url")]
        public string RedirectUrl { get; set; }
    }
}
