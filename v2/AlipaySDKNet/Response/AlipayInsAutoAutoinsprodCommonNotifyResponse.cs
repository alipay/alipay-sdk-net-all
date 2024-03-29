using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsAutoAutoinsprodCommonNotifyResponse.
    /// </summary>
    public class AlipayInsAutoAutoinsprodCommonNotifyResponse : AopResponse
    {
        /// <summary>
        /// 具体内容按照业务类型对应的key值传输
        /// </summary>
        [XmlElement("biz_data")]
        public string BizData { get; set; }
    }
}
