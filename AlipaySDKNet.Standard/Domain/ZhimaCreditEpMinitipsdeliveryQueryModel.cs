using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditEpMinitipsdeliveryQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpMinitipsdeliveryQueryModel : AopObject
    {
        /// <summary>
        /// 无openid字段
        /// </summary>
        [XmlElement("hhh")]
        public long Hhh { get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        [XmlElement("xx")]
        public string Xx { get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        [XmlElement("xx_open_id")]
        public string XxOpenId { get; set; }
    }
}
