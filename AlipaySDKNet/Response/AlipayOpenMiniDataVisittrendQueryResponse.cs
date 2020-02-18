using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniDataVisittrendQueryResponse.
    /// </summary>
    public class AlipayOpenMiniDataVisittrendQueryResponse : AopResponse
    {
        /// <summary>
        /// 小程序实时访问趋势结果
        /// </summary>
        [XmlArray("app_visit_trend_data_list_response")]
        [XmlArrayItem("app_visit_trend_data_response")]
        public List<AppVisitTrendDataResponse> AppVisitTrendDataListResponse { get; set; }
    }
}
