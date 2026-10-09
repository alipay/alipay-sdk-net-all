using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppEbppTransferTransferbillkeyQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppEbppTransferTransferbillkeyQueryModel : AopObject
    {
        /// <summary>
        /// 户号所属的出账机构
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
