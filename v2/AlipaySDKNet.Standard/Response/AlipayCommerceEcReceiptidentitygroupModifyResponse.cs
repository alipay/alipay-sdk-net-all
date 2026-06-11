using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcReceiptidentitygroupModifyResponse.
    /// </summary>
    public class AlipayCommerceEcReceiptidentitygroupModifyResponse : AopResponse
    {
        /// <summary>
        /// 修改结果是否成功
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
