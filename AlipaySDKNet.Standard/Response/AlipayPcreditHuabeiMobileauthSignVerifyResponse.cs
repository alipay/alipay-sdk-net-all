using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiMobileauthSignVerifyResponse.
    /// </summary>
    public class AlipayPcreditHuabeiMobileauthSignVerifyResponse : AopResponse
    {
        /// <summary>
        /// 模板查询返回JSON信息，参考 PcreditAuthPageSignVerifyResult
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
