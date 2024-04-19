using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundMbpcardCardQueryResponse.
    /// </summary>
    public class AlipayFundMbpcardCardQueryResponse : AopResponse
    {
        /// <summary>
        /// 卡详情列表信息
        /// </summary>
        [XmlElement("mbp_card_list")]
        public CardDetailInfo MbpCardList { get; set; }
    }
}
