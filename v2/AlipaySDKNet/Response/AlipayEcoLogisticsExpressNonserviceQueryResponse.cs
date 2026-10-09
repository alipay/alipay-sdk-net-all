using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoLogisticsExpressNonserviceQueryResponse.
    /// </summary>
    public class AlipayEcoLogisticsExpressNonserviceQueryResponse : AopResponse
    {
        /// <summary>
        /// 非服务区区域代码列表
        /// </summary>
        [XmlArray("area_codes")]
        [XmlArrayItem("area_code")]
        public List<AreaCode> AreaCodes { get; set; }
    }
}
