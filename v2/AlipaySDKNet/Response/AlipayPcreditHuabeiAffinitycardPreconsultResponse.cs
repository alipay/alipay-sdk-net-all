using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiAffinitycardPreconsultResponse.
    /// </summary>
    public class AlipayPcreditHuabeiAffinitycardPreconsultResponse : AopResponse
    {
        /// <summary>
        /// 是否可开通联名卡
        /// </summary>
        [XmlElement("can_apply")]
        public bool CanApply { get; set; }
    }
}
