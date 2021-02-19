using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SignCardInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SignCardInfo : AopObject
    {
        /// <summary>
        /// 完整卡号的SHA256摘要并对结果进行16进制编码
        /// </summary>
        [XmlElement("card_no_en")]
        public string CardNoEn { get; set; }

        /// <summary>
        /// 卡号前八位
        /// </summary>
        [XmlElement("first_eight_card_no")]
        public string FirstEightCardNo { get; set; }
    }
}
