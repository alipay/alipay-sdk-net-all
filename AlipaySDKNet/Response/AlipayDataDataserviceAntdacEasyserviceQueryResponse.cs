using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceAntdacEasyserviceQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceAntdacEasyserviceQueryResponse : AopResponse
    {
        /// <summary>
        /// 方法返回值＋json字符串格式
        /// </summary>
        [XmlElement("ret_val")]
        public string RetVal { get; set; }
    }
}
