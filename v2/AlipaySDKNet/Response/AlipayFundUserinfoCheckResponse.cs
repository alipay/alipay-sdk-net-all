using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundUserinfoCheckResponse.
    /// </summary>
    public class AlipayFundUserinfoCheckResponse : AopResponse
    {
        /// <summary>
        /// 是否校验通过 true: 通过 false:不通过
        /// </summary>
        [XmlElement("is_pass")]
        public bool IsPass { get; set; }
    }
}
