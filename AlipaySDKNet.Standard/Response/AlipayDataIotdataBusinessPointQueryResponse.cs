using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataIotdataBusinessPointQueryResponse.
    /// </summary>
    public class AlipayDataIotdataBusinessPointQueryResponse : AopResponse
    {
        /// <summary>
        /// 业务点位信息列表
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("business_point")]
        public List<BusinessPoint> Data { get; set; }
    }
}
