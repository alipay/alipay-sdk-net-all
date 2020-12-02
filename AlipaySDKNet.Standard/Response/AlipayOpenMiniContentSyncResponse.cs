using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniContentSyncResponse.
    /// </summary>
    public class AlipayOpenMiniContentSyncResponse : AopResponse
    {
        /// <summary>
        /// 结果数据，json格式，可参考具体内容接入文档中的详细说明。详见https://opendocs.alipay.com/mini/00ntj5。
        /// </summary>
        [XmlElement("result_data")]
        public string ResultData { get; set; }
    }
}
