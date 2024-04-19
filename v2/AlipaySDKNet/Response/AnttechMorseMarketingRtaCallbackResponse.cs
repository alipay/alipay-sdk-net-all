using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechMorseMarketingRtaCallbackResponse.
    /// </summary>
    public class AnttechMorseMarketingRtaCallbackResponse : AopResponse
    {
        /// <summary>
        /// 业务唯一标识，标识本次查询的唯一识别号，用于问题定位
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }
    }
}
