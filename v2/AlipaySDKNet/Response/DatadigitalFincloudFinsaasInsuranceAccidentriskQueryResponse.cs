using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// DatadigitalFincloudFinsaasInsuranceAccidentriskQueryResponse.
    /// </summary>
    public class DatadigitalFincloudFinsaasInsuranceAccidentriskQueryResponse : AopResponse
    {
        /// <summary>
        /// 是否查得此用户，查得返回true，否则返回false
        /// </summary>
        [XmlElement("found")]
        public bool Found { get; set; }

        /// <summary>
        /// 包括两种返回形式： ● 风险等级：0-N表示风险从低到高排列（N值线下确认） ● 风险分值：0-99.99表示风险从低到高排列 注：未查得不返回结果。
        /// </summary>
        [XmlElement("risk_result")]
        public string RiskResult { get; set; }
    }
}
