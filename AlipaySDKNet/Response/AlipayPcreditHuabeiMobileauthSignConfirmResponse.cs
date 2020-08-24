using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiMobileauthSignConfirmResponse.
    /// </summary>
    public class AlipayPcreditHuabeiMobileauthSignConfirmResponse : AopResponse
    {
        /// <summary>
        /// 模板查询返回JSON信息，参考 PcreditAuthSignConfirmResult
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
