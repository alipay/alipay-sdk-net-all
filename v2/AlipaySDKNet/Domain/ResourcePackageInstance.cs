using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ResourcePackageInstance Data Structure.
    /// </summary>
    [Serializable]
    public class ResourcePackageInstance : AopObject
    {
        /// <summary>
        /// 结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 资源包规格CODE  - public_cloudd_cd_cn_free_bag  - public_cloudd_cd_cn_base_bag  - public_cloudd_cd_cn_standard_bag  - public_cloudd_cd_cn_pro_bag  - public_cloudd_cd_cn_ent_bag  - public_cloudd_cd_cn_flagship_bag
        /// </summary>
        [XmlElement("spec_code")]
        public string SpecCode { get; set; }

        /// <summary>
        /// 资源包规格实例ID
        /// </summary>
        [XmlElement("spec_instance_id")]
        public string SpecInstanceId { get; set; }

        /// <summary>
        /// 资源包规格名称  - 云开发免费版  - 云开发基础版  - 云开发标准版  - 云开发专业版  - 云开发企业版  - 云开发旗舰版
        /// </summary>
        [XmlElement("spec_name")]
        public string SpecName { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
