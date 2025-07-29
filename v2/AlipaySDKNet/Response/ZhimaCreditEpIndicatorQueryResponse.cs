using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpIndicatorQueryResponse.
    /// </summary>
    public class ZhimaCreditEpIndicatorQueryResponse : AopResponse
    {
        /// <summary>
        /// 数据集
        /// </summary>
        [XmlArray("array_data")]
        [XmlArrayItem("ep_risk_indicator_model")]
        public List<EpRiskIndicatorModel> ArrayData { get; set; }

        /// <summary>
        /// 企业查询key
        /// </summary>
        [XmlElement("company_key")]
        public string CompanyKey { get; set; }
    }
}
