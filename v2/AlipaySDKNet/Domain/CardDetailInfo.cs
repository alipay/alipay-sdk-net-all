using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CardDetailInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CardDetailInfo : AopObject
    {
        /// <summary>
        /// 当前余额，单位元，精确到分
        /// </summary>
        [XmlElement("balance")]
        public string Balance { get; set; }

        /// <summary>
        /// 卡背景图片
        /// </summary>
        [XmlElement("card_bg_image")]
        public string CardBgImage { get; set; }

        /// <summary>
        /// 卡LOGO地址
        /// </summary>
        [XmlElement("card_logo")]
        public string CardLogo { get; set; }

        /// <summary>
        /// 卡名称
        /// </summary>
        [XmlElement("card_name")]
        public string CardName { get; set; }

        /// <summary>
        /// 卡号
        /// </summary>
        [XmlElement("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 初始面额，单位元，精确到分
        /// </summary>
        [XmlElement("origin_amount")]
        public string OriginAmount { get; set; }

        /// <summary>
        /// 截止时间
        /// </summary>
        [XmlElement("valid_end_date")]
        public string ValidEndDate { get; set; }

        /// <summary>
        /// 起始时间
        /// </summary>
        [XmlElement("valid_start_date")]
        public string ValidStartDate { get; set; }
    }
}
