using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundMbpcardGencardQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundMbpcardGencardQueryModel : AopObject
    {
        /// <summary>
        /// 制卡单号；out_request_no和gen_card_no二选一
        /// </summary>
        [XmlElement("gen_card_no")]
        public string GenCardNo { get; set; }

        /// <summary>
        /// 外部单号；out_request_no和gen_card_no二选一
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }
    }
}
