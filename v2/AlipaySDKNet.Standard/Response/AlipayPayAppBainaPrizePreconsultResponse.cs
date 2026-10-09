using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPayAppBainaPrizePreconsultResponse.
    /// </summary>
    public class AlipayPayAppBainaPrizePreconsultResponse : AopResponse
    {
        /// <summary>
        /// 该字段表示用户是否可下单，true=可以下单，false=不能下单
        /// </summary>
        [XmlElement("allow_award")]
        public bool AllowAward { get; set; }
    }
}
