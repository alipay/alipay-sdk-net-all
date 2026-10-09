using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// SsdataDataserviceRiskAntimarketcheatQueryResponse.
    /// </summary>
    public class SsdataDataserviceRiskAntimarketcheatQueryResponse : AopResponse
    {
        /// <summary>
        /// 风险解释，从垃圾注册、虚假交易、名单库、身份冒用和不良记录等5个方面描述作弊风险
        /// </summary>
        [XmlElement("infocode")]
        public string Infocode { get; set; }

        /// <summary>
        /// 基于传入手机号或身份证号，计算得到的作弊风险值，范围[0,100],分数越高风险程度越高
        /// </summary>
        [XmlElement("score")]
        public string Score { get; set; }

        /// <summary>
        /// 用户唯一请求ID
        /// </summary>
        [XmlElement("unique_id")]
        public string UniqueId { get; set; }
    }
}
