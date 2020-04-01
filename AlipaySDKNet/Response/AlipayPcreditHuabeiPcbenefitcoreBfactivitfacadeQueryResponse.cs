using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiPcbenefitcoreBfactivitfacadeQueryResponse.
    /// </summary>
    public class AlipayPcreditHuabeiPcbenefitcoreBfactivitfacadeQueryResponse : AopResponse
    {
        /// <summary>
        /// 错误信息，参考通用错误格式
        /// </summary>
        [XmlArray("error_context")]
        [XmlArrayItem("string")]
        public List<string> ErrorContext { get; set; }

        /// <summary>
        /// 花呗营销活动信息返回数据
        /// </summary>
        [XmlElement("result")]
        public BFActivityOpenApiResult Result { get; set; }

        /// <summary>
        /// 请求是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
