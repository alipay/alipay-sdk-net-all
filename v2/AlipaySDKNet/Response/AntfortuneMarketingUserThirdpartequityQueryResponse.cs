using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntfortuneMarketingUserThirdpartequityQueryResponse.
    /// </summary>
    public class AntfortuneMarketingUserThirdpartequityQueryResponse : AopResponse
    {
        /// <summary>
        /// 权益基础信息
        /// </summary>
        [XmlArray("equity_info")]
        [XmlArrayItem("fin_equity_info")]
        public List<FinEquityInfo> EquityInfo { get; set; }

        /// <summary>
        /// 是否推荐重试
        /// </summary>
        [XmlElement("should_retry")]
        public bool ShouldRetry { get; set; }
    }
}
