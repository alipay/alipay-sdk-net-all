using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpBusinessIndicatorQueryResponse.
    /// </summary>
    public class ZhimaCreditEpBusinessIndicatorQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("array_data")]
        [XmlArrayItem("ep_business_indicator")]
        public List<EpBusinessIndicator> ArrayData { get; set; }

        /// <summary>
        /// 业务关键词
        /// </summary>
        [XmlElement("business_key")]
        public string BusinessKey { get; set; }
    }
}
