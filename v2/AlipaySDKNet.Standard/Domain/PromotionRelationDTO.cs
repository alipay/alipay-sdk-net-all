using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PromotionRelationDTO Data Structure.
    /// </summary>
    [Serializable]
    public class PromotionRelationDTO : AopObject
    {
        /// <summary>
        /// 申请推广时填写的申请理由
        /// </summary>
        [XmlElement("apply_reason")]
        public string ApplyReason { get; set; }

        /// <summary>
        /// 服务商品ID
        /// </summary>
        [XmlElement("commodity_id")]
        public string CommodityId { get; set; }

        /// <summary>
        /// 服务商品名称
        /// </summary>
        [XmlElement("commodity_name")]
        public string CommodityName { get; set; }

        /// <summary>
        /// 推广关系创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 推广服务商联系人名称
        /// </summary>
        [XmlElement("promoter_contact_name")]
        public string PromoterContactName { get; set; }

        /// <summary>
        /// 推广服务商联系电话
        /// </summary>
        [XmlElement("promoter_contact_phone")]
        public string PromoterContactPhone { get; set; }

        /// <summary>
        /// 推广服务商的名称
        /// </summary>
        [XmlElement("promoter_name")]
        public string PromoterName { get; set; }

        /// <summary>
        /// 推广服务商的pid
        /// </summary>
        [XmlElement("promoter_pid")]
        public string PromoterPid { get; set; }

        /// <summary>
        /// 推广任务id
        /// </summary>
        [XmlElement("promotion_id")]
        public string PromotionId { get; set; }

        /// <summary>
        /// 推广任务的名称
        /// </summary>
        [XmlElement("promotion_name")]
        public string PromotionName { get; set; }
    }
}
