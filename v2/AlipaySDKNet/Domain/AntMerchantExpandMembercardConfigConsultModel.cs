using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandMembercardConfigConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandMembercardConfigConsultModel : AopObject
    {
        /// <summary>
        /// 期望修改的配置
        /// </summary>
        [XmlElement("member_card_set_modify_request")]
        public MemberCardSetModifyRequest MemberCardSetModifyRequest { get; set; }
    }
}
