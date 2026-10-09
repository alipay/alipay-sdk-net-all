using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMerchantcardManageTransferModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMerchantcardManageTransferModel : AopObject
    {
        /// <summary>
        /// 待转移的卡id集合，即将这些卡转移到自己名下。当前仅支持安心付标准版卡转移
        /// </summary>
        [XmlArray("card_template_ids")]
        [XmlArrayItem("string")]
        public List<string> CardTemplateIds { get; set; }
    }
}
