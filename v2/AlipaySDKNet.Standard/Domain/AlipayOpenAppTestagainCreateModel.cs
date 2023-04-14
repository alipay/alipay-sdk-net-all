using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppTestagainCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppTestagainCreateModel : AopObject
    {
        /// <summary>
        /// 在门店消费用户的标识
        /// </summary>
        [XmlElement("buyer_openid")]
        public string BuyerOpenid { get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        [XmlElement("xxxxxx")]
        public string Xxxxxx { get; set; }
    }
}
