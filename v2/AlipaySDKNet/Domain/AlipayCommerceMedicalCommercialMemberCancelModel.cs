using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalCommercialMemberCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalCommercialMemberCancelModel : AopObject
    {
        /// <summary>
        /// 会员的会员卡号，字符串类型
        /// </summary>
        [XmlElement("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 13位手机号
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }
    }
}
