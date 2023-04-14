using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiMarketingDataMallCheckGetResponse.
    /// </summary>
    public class KoubeiMarketingDataMallCheckGetResponse : AopResponse
    {
        /// <summary>
        /// 返回数据字段
        /// </summary>
        [XmlArray("data_results")]
        [XmlArrayItem("data_sec_check_result")]
        public List<DataSecCheckResult> DataResults { get; set; }
    }
}
