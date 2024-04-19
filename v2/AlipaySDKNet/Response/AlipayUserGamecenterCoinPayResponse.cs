using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserGamecenterCoinPayResponse.
    /// </summary>
    public class AlipayUserGamecenterCoinPayResponse : AopResponse
    {
        /// <summary>
        /// 预扣后的用户游戏币余额
        /// </summary>
        [XmlElement("balance")]
        public long Balance { get; set; }

        /// <summary>
        /// 平台生成的用户游戏币扣减交易号
        /// </summary>
        [XmlElement("deduct_no")]
        public string DeductNo { get; set; }
    }
}
