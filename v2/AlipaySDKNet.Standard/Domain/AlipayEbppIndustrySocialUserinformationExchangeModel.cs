using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustrySocialUserinformationExchangeModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustrySocialUserinformationExchangeModel : AopObject
    {
        /// <summary>
        /// 社保签发号
        /// </summary>
        [XmlElement("ins_card_id_encrypt")]
        public string InsCardIdEncrypt { get; set; }

        /// <summary>
        /// 解密iv
        /// </summary>
        [XmlElement("sm_4_iv")]
        public string Sm4Iv { get; set; }
    }
}
