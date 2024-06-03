using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudbaseCouponsAlterQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudbaseCouponsAlterQueryModel : AopObject
    {
        /// <summary>
        /// 变配资源包规格编码  - public_cloudd_cd_cn_free_bag  - public_cloudd_cd_cn_base_bag  - public_cloudd_cd_cn_standard_bag  - public_cloudd_cd_cn_pro_bag  - public_cloudd_cd_cn_ent_bag  - public_cloudd_cd_cn_flagship_bag  - public_cloudd_cd_cn_free_bag
        /// </summary>
        [XmlElement("alter_spec_code")]
        public string AlterSpecCode { get; set; }

        /// <summary>
        /// 变配商品规格类型  - ALTERATION_UP  - ALTERATION_DOWN
        /// </summary>
        [XmlElement("alter_type")]
        public string AlterType { get; set; }

        /// <summary>
        /// 应用ID
        /// </summary>
        [XmlElement("biz_app_id")]
        public string BizAppId { get; set; }

        /// <summary>
        /// 环境ID
        /// </summary>
        [XmlElement("biz_env_id")]
        public string BizEnvId { get; set; }
    }
}
