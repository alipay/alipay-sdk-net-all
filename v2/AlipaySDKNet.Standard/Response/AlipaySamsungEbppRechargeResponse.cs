using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySamsungEbppRechargeResponse.
    /// </summary>
    public class AlipaySamsungEbppRechargeResponse : AopResponse
    {
        /// <summary>
        /// 直接返回页面
        /// </summary>
        [XmlElement("page_retrun")]
        public string PageRetrun { get; set; }
    }
}
