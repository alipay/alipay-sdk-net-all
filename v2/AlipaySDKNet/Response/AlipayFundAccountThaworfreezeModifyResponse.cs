using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundAccountThaworfreezeModifyResponse.
    /// </summary>
    public class AlipayFundAccountThaworfreezeModifyResponse : AopResponse
    {
        /// <summary>
        /// 淘宝uid
        /// </summary>
        [XmlElement("taobao_user_id")]
        public string TaobaoUserId { get; set; }
    }
}
