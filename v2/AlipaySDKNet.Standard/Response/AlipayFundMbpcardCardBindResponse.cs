using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundMbpcardCardBindResponse.
    /// </summary>
    public class AlipayFundMbpcardCardBindResponse : AopResponse
    {
        /// <summary>
        /// 绑卡结果
        /// </summary>
        [XmlElement("bind_result")]
        public bool BindResult { get; set; }

        /// <summary>
        /// 卡号
        /// </summary>
        [XmlElement("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 卡面额；单位元，精确到分
        /// </summary>
        [XmlElement("origin_amount")]
        public string OriginAmount { get; set; }

        /// <summary>
        /// 卡片有效期-截止，yyyy-MM-dd
        /// </summary>
        [XmlElement("valid_end_date")]
        public string ValidEndDate { get; set; }

        /// <summary>
        /// 卡片有效期-起始，yyyy-MM-dd
        /// </summary>
        [XmlElement("valid_start_date")]
        public string ValidStartDate { get; set; }
    }
}
