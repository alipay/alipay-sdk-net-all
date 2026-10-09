using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpBusinesslocationQueryResponse.
    /// </summary>
    public class ZhimaCreditEpBusinesslocationQueryResponse : AopResponse
    {
        /// <summary>
        /// 商户地理位置信息列表
        /// </summary>
        [XmlArray("array_data")]
        [XmlArrayItem("zm_ep_business_location_info")]
        public List<ZmEpBusinessLocationInfo> ArrayData { get; set; }
    }
}
