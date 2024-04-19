using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiMobileauthTemplateQueryResponse.
    /// </summary>
    public class AlipayPcreditHuabeiMobileauthTemplateQueryResponse : AopResponse
    {
        /// <summary>
        /// 模板查询返回JSON信息，参考 PcreditRpcBaseResult<MobileMemberTemplateInfoVO>
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
