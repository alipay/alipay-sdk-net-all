using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiCateringOrderBillApplyResponse.
    /// </summary>
    public class KoubeiCateringOrderBillApplyResponse : AopResponse
    {
        /// <summary>
        /// 是否需要重试
        /// </summary>
        [XmlElement("retry")]
        public bool Retry { get; set; }
    }
}
