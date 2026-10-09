using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenSpCanteenOpenQueryResponse.
    /// </summary>
    public class AlipayOpenSpCanteenOpenQueryResponse : AopResponse
    {
        /// <summary>
        /// 用于描述用户是否已经开通功能，如果没有开通，则需要跳转到签约页面，否则进入服务商小程序
        /// </summary>
        [XmlElement("open_status")]
        public string OpenStatus { get; set; }
    }
}
