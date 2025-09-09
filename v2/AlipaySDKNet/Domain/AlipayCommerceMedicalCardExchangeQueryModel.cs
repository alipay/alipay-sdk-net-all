using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalCardExchangeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalCardExchangeQueryModel : AopObject
    {
        /// <summary>
        /// 会员卡流水ID
        /// </summary>
        [XmlElement("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 16位字符串，无分隔符
        /// </summary>
        [XmlElement("member_code")]
        public string MemberCode { get; set; }

        /// <summary>
        /// 电话号码
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }
    }
}
