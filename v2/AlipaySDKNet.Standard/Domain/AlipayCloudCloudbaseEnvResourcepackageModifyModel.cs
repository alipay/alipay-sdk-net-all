using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudbaseEnvResourcepackageModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudbaseEnvResourcepackageModifyModel : AopObject
    {
        /// <summary>
        /// 小程序id
        /// </summary>
        [XmlElement("biz_app_id")]
        public string BizAppId { get; set; }

        /// <summary>
        /// 环境id
        /// </summary>
        [XmlElement("biz_env_id")]
        public string BizEnvId { get; set; }

        /// <summary>
        /// 区域
        /// </summary>
        [XmlElement("region")]
        public string Region { get; set; }

        /// <summary>
        /// 资源包规格CODE  - public_cloudd_cd_cn_free_bag  - public_cloudd_cd_cn_basic_bag  - public_cloudd_cd_cn_standard_bag  - public_cloudd_cd_cn_pro_bag  - public_cloudd_cd_cn_enterprise_bag  - public_cloudd_cd_cn_flagship_bag
        /// </summary>
        [XmlElement("resource_spec_code")]
        public string ResourceSpecCode { get; set; }
    }
}
