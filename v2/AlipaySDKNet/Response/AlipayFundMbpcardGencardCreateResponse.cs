using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundMbpcardGencardCreateResponse.
    /// </summary>
    public class AlipayFundMbpcardGencardCreateResponse : AopResponse
    {
        /// <summary>
        /// 制卡单据下单成功之后返回的单号，可以用来查询进度
        /// </summary>
        [XmlElement("gen_card_no")]
        public string GenCardNo { get; set; }

        /// <summary>
        /// 表示制卡单据的业务状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
