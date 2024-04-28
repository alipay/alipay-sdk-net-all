using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMerchantcardTemplatestatusModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMerchantcardTemplatestatusModifyModel : AopObject
    {
        /// <summary>
        /// 商品ID
        /// </summary>
        [XmlElement("card_template_id")]
        public string CardTemplateId { get; set; }

        /// <summary>
        /// 操作类型，发布或下架
        /// </summary>
        [XmlElement("operate_status")]
        public string OperateStatus { get; set; }
    }
}
