using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMerchantcardManageTransferResponse.
    /// </summary>
    public class AlipayCommerceMerchantcardManageTransferResponse : AopResponse
    {
        /// <summary>
        /// 发起成功的卡id集合
        /// </summary>
        [XmlArray("card_template_ids")]
        [XmlArrayItem("string")]
        public List<string> CardTemplateIds { get; set; }

        /// <summary>
        /// 商家确认链接，商家自调用时不返回
        /// </summary>
        [XmlElement("confirm_link")]
        public string ConfirmLink { get; set; }

        /// <summary>
        /// 发起转移失败的原因
        /// </summary>
        [XmlArray("fail_card_reasons")]
        [XmlArrayItem("fail_card_reason")]
        public List<FailCardReason> FailCardReasons { get; set; }
    }
}
