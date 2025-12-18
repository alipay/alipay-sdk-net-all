using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalCommercialMemberCheckResponse.
    /// </summary>
    public class AlipayCommerceMedicalCommercialMemberCheckResponse : AopResponse
    {
        /// <summary>
        /// 已开通的卡id
        /// </summary>
        [XmlElement("card_id")]
        public string CardId { get; set; }

        /// <summary>
        /// 卡号
        /// </summary>
        [XmlElement("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 资产状态
        /// </summary>
        [XmlElement("card_status")]
        public string CardStatus { get; set; }

        /// <summary>
        /// 过期时间
        /// </summary>
        [XmlElement("expire_time")]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 是否已开卡
        /// </summary>
        [XmlElement("open")]
        public bool Open { get; set; }

        /// <summary>
        /// 开卡时间
        /// </summary>
        [XmlElement("open_time")]
        public string OpenTime { get; set; }
    }
}
