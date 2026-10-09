using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppJfSignConsultResponse.
    /// </summary>
    public class AlipayEbppJfSignConsultResponse : AopResponse
    {
        /// <summary>
        /// 咨询结果代码,允许签约时为SUCCESS, 其他情况根据不同的机构返回咨询异常设置
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 签约结果文案, 当允许签约时为空
        /// </summary>
        [XmlElement("result_msg")]
        public string ResultMsg { get; set; }

        /// <summary>
        /// 是否允许签约
        /// </summary>
        [XmlElement("sign_allowed")]
        public bool SignAllowed { get; set; }
    }
}
