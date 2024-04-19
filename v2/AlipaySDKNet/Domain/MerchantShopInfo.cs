using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MerchantShopInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MerchantShopInfo : AopObject
    {
        /// <summary>
        /// 审核驳回原因
        /// </summary>
        [XmlElement("audit_desc")]
        public string AuditDesc { get; set; }

        /// <summary>
        /// 商家的pid
        /// </summary>
        [XmlElement("merchant_pid")]
        public string MerchantPid { get; set; }

        /// <summary>
        /// 商家门店编码，可自定义，但必须唯一
        /// </summary>
        [XmlElement("shop_no")]
        public string ShopNo { get; set; }

        /// <summary>
        /// 门店状态，AUDITING:审核中，AUDIT_REJECT:审核驳回，VALID:已生效，UPDATING:更新中，INVALID:已失效
        /// </summary>
        [XmlElement("shop_status")]
        public string ShopStatus { get; set; }
    }
}
