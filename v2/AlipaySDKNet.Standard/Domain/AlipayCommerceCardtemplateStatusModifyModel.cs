using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceCardtemplateStatusModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceCardtemplateStatusModifyModel : AopObject
    {
        /// <summary>
        /// 卡模版ID
        /// </summary>
        [XmlElement("card_template_id")]
        public string CardTemplateId { get; set; }

        /// <summary>
        /// 商户pid
        /// </summary>
        [XmlElement("merchant_pid")]
        public string MerchantPid { get; set; }

        /// <summary>
        /// 操作
        /// </summary>
        [XmlElement("operate_status")]
        public string OperateStatus { get; set; }
    }
}
