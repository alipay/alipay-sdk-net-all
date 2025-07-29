using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class OpenInfoDTO : AopObject
    {
        /// <summary>
        /// 会员卡流水ID
        /// </summary>
        [XmlElement("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 券码有效期，时间戳
        /// </summary>
        [XmlElement("expiration_date")]
        public long ExpirationDate { get; set; }

        /// <summary>
        /// 1-已开通   2-未开通
        /// </summary>
        [XmlElement("open_status")]
        public long OpenStatus { get; set; }

        /// <summary>
        /// 开通时间
        /// </summary>
        [XmlElement("open_time")]
        public long OpenTime { get; set; }
    }
}
