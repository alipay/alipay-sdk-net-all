using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechMorseMarketingSrtaNanonymousCallbackResponse.
    /// </summary>
    public class AnttechMorseMarketingSrtaNanonymousCallbackResponse : AopResponse
    {
        /// <summary>
        /// 业务请求唯一标识，用于链路问题排查和对账
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 本次调用回调结果，标识是否回调成功，true：回调成功；false：回调失败
        /// </summary>
        [XmlElement("callback_result")]
        public bool CallbackResult { get; set; }
    }
}
