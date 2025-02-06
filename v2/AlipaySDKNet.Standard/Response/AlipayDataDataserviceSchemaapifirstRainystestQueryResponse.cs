using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceSchemaapifirstRainystestQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceSchemaapifirstRainystestQueryResponse : AopResponse
    {
        /// <summary>
        /// 获取签名后的业务数据
        /// </summary>
        [XmlElement("orderStr")]
        public string OrderStr { get; set; }
    }
}
