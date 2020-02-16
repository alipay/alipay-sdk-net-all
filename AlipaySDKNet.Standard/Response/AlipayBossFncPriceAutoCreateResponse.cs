using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossFncPriceAutoCreateResponse.
    /// </summary>
    public class AlipayBossFncPriceAutoCreateResponse : AopResponse
    {
        /// <summary>
        /// 结果码
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 价格创建的返回结果
        /// </summary>
        [XmlElement("result_detail")]
        public string ResultDetail { get; set; }

        /// <summary>
        /// 结果信息
        /// </summary>
        [XmlElement("result_msg")]
        public string ResultMsg { get; set; }
    }
}
