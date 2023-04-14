using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankMarketingMcaplatformContractQueryResponse.
    /// </summary>
    public class MybankMarketingMcaplatformContractQueryResponse : AopResponse
    {
        /// <summary>
        /// sign_status, 唯一，绿色经营签约查询 枚举值： S 2.0签约 Y 1.0签约 F 解约 N 未签约
        /// </summary>
        [XmlElement("sign_status")]
        public string SignStatus { get; set; }
    }
}
