using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EcsignSealOpenVO Data Structure.
    /// </summary>
    [Serializable]
    public class EcsignSealOpenVO : AopObject
    {
        /// <summary>
        /// 企业社会统一信用代码，无需唯一，用户企业信息校验及授权，需要与企业名称对应。
        /// </summary>
        [XmlElement("enterprise_cert_no")]
        public string EnterpriseCertNo { get; set; }

        /// <summary>
        /// 企业名称，无需唯一，用于验证统一社会信用代码及授权，需要与企业社会信用代码对应。
        /// </summary>
        [XmlElement("enterprise_name")]
        public string EnterpriseName { get; set; }

        /// <summary>
        /// 印章创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 印章更新时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 印章图片预览链接,唯一值，每一个印章ID对应一个预览链接，由系统生成。
        /// </summary>
        [XmlElement("preview_url")]
        public string PreviewUrl { get; set; }

        /// <summary>
        /// 印章描述，无需唯一，用于描述印章，用户自行定义。
        /// </summary>
        [XmlElement("seal_description")]
        public string SealDescription { get; set; }

        /// <summary>
        /// 印章ID，如果有则为唯一值，用于印章更新场景，在创建完和更新完均会返回该值。
        /// </summary>
        [XmlElement("seal_id")]
        public string SealId { get; set; }

        /// <summary>
        /// 印章名称，无需唯一，用于印章命名，来源是用户自定义。
        /// </summary>
        [XmlElement("seal_name")]
        public string SealName { get; set; }

        /// <summary>
        /// 印章状态，只有NORMAL是代表印章是可用状态。
        /// </summary>
        [XmlElement("seal_status")]
        public string SealStatus { get; set; }

        /// <summary>
        /// 印章类型，无需唯一，用于生成印章图片，枚举值。
        /// </summary>
        [XmlElement("seal_type")]
        public string SealType { get; set; }
    }
}
