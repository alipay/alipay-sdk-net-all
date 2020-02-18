using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppConfigProvinceSearchResponse.
    /// </summary>
    public class AlipayEbppConfigProvinceSearchResponse : AopResponse
    {
        /// <summary>
        /// 接口主要输出参数列表: AreaInfoResult{List{ areaInfo：{province, cityList<String>}} }
        /// </summary>
        [XmlArray("area_info_result")]
        [XmlArrayItem("area_info")]
        public List<AreaInfo> AreaInfoResult { get; set; }
    }
}
