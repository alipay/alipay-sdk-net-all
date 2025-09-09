using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalPromoPointQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalPromoPointQueryResponse : AopResponse
    {
        /// <summary>
        /// 用户积分数
        /// </summary>
        [XmlElement("num")]
        public long Num { get; set; }
    }
}
