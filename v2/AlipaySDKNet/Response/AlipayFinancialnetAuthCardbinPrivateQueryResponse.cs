using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFinancialnetAuthCardbinPrivateQueryResponse.
    /// </summary>
    public class AlipayFinancialnetAuthCardbinPrivateQueryResponse : AopResponse
    {
        /// <summary>
        /// 卡类型，CC为信用卡，DC为借记卡
        /// </summary>
        [XmlElement("card_type")]
        public string CardType { get; set; }

        /// <summary>
        /// 机构ID
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 机构名称
        /// </summary>
        [XmlElement("inst_name")]
        public string InstName { get; set; }
    }
}
