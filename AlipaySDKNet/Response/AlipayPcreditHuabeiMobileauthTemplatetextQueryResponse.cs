using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiMobileauthTemplatetextQueryResponse.
    /// </summary>
    public class AlipayPcreditHuabeiMobileauthTemplatetextQueryResponse : AopResponse
    {
        /// <summary>
        /// 模板查询返回JSON信息，参考 PcreditRpcBaseResult<MemberTemplate>
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
