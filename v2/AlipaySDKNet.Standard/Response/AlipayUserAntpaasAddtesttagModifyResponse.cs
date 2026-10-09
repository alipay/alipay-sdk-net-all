using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserAntpaasAddtesttagModifyResponse.
    /// </summary>
    public class AlipayUserAntpaasAddtesttagModifyResponse : AopResponse
    {
        /// <summary>
        /// 返回是否有标记或者是否达标成功，success，msg
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
