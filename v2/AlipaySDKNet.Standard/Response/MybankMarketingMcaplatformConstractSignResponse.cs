using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankMarketingMcaplatformConstractSignResponse.
    /// </summary>
    public class MybankMarketingMcaplatformConstractSignResponse : AopResponse
    {
        /// <summary>
        /// 签约返回结果，绿色经营签约场景
        /// </summary>
        [XmlElement("sign_result")]
        public bool SignResult { get; set; }
    }
}
