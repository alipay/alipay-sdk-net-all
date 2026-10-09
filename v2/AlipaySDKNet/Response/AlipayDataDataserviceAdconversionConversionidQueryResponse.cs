using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdconversionConversionidQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceAdconversionConversionidQueryResponse : AopResponse
    {
        /// <summary>
        /// 转化事件基础信息列表
        /// </summary>
        [XmlArray("converted_detail_list")]
        [XmlArrayItem("converted_detail")]
        public List<ConvertedDetail> ConvertedDetailList { get; set; }
    }
}
