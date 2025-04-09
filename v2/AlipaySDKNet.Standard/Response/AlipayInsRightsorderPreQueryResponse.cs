using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsRightsorderPreQueryResponse.
    /// </summary>
    public class AlipayInsRightsorderPreQueryResponse : AopResponse
    {
        /// <summary>
        /// 当前订单是否有效，true表示有效，可继续执行下单
        /// </summary>
        [XmlElement("valid")]
        public bool Valid { get; set; }
    }
}
