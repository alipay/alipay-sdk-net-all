using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudbaseResourcepackageAlterCreateandpayModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudbaseResourcepackageAlterCreateandpayModel : AopObject
    {
        /// <summary>
        /// 待变配的资源包规格编码  - public_cloudd_cd_cn_free_bag  - public_cloudd_cd_cn_base_bag  - public_cloudd_cd_cn_standard_bag  - public_cloudd_cd_cn_pro_bag  - public_cloudd_cd_cn_ent_bag  - public_cloudd_cd_cn_flagship_bag
        /// </summary>
        [XmlElement("alter_spec_code")]
        public string AlterSpecCode { get; set; }

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
    }
}
