using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcReceiptidentitygroupDeleteResponse.
    /// </summary>
    public class AlipayCommerceEcReceiptidentitygroupDeleteResponse : AopResponse
    {
        /// <summary>
        /// 删除结果是否成功
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
