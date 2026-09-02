using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundAccountbookExtcardCreateResponse.
    /// </summary>
    public class AlipayFundAccountbookExtcardCreateResponse : AopResponse
    {
        /// <summary>
        /// 场景码
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 记账的外卡创建时间，格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("card_create_time")]
        public string CardCreateTime { get; set; }

        /// <summary>
        /// 记账的外卡卡号
        /// </summary>
        [XmlElement("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 记账的外卡状态, NORMAL ：正常
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
