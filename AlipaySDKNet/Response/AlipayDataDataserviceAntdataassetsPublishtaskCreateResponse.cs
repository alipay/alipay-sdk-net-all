using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceAntdataassetsPublishtaskCreateResponse.
    /// </summary>
    public class AlipayDataDataserviceAntdataassetsPublishtaskCreateResponse : AopResponse
    {
        /// <summary>
        /// 发布D2任务是否成功
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
