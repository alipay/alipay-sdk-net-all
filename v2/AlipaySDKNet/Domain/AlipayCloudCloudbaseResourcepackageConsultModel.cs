using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudbaseResourcepackageConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudbaseResourcepackageConsultModel : AopObject
    {
        /// <summary>
        /// 资源包时间单位数量
        /// </summary>
        [XmlElement("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// 资源包规格CODE  - public_cloudd_cd_cn_free_bag  - public_cloudd_cd_cn_basic_bag  - public_cloudd_cd_cn_standard_bag  - public_cloudd_cd_cn_pro_bag  - public_cloudd_cd_cn_enterprise_bag  - public_cloudd_cd_cn_flagship_bag
        /// </summary>
        [XmlElement("spec_code")]
        public string SpecCode { get; set; }

        /// <summary>
        /// 资源包时间单位  - 1_M
        /// </summary>
        [XmlElement("time_unit")]
        public string TimeUnit { get; set; }
    }
}
