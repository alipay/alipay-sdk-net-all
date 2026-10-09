using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcBalancePeriodModifyResponse.
    /// </summary>
    public class AlipayCommerceEcBalancePeriodModifyResponse : AopResponse
    {
        /// <summary>
        /// 修改结果
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
