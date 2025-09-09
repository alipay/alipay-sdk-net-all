using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudbaseCouponsOpenQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudbaseCouponsOpenQueryModel : AopObject
    {
        /// <summary>
        /// 应用ID
        /// </summary>
        [XmlElement("biz_app_id")]
        public string BizAppId { get; set; }

        /// <summary>
        /// 购买时长(月)
        /// </summary>
        [XmlElement("purchase_month")]
        public long PurchaseMonth { get; set; }

        /// <summary>
        /// 资源包规格编码  - public_cloudd_cd_cn_free_bag  - public_cloudd_cd_cn_base_bag  - public_cloudd_cd_cn_standard_bag  - public_cloudd_cd_cn_pro_bag  - public_cloudd_cd_cn_ent_bag  - public_cloudd_cd_cn_flagship_bag
        /// </summary>
        [XmlElement("spec_code")]
        public string SpecCode { get; set; }
    }
}
