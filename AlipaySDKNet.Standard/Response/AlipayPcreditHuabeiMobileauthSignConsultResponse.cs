using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiMobileauthSignConsultResponse.
    /// </summary>
    public class AlipayPcreditHuabeiMobileauthSignConsultResponse : AopResponse
    {
        /// <summary>
        /// 模板查询返回JSON信息，参考 PcreditAuthSignApplyResult
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
