using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UserBenefitInfo Data Structure.
    /// </summary>
    [Serializable]
    public class UserBenefitInfo : AopObject
    {
        /// <summary>
        /// 结束时间
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 权益实体id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 跳转链接
        /// </summary>
        [XmlElement("jump_url")]
        public string JumpUrl { get; set; }

        /// <summary>
        /// 产品类型
        /// </summary>
        [XmlElement("product_type")]
        public string ProductType { get; set; }

        /// <summary>
        /// 权益开始时间
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 权益子标题
        /// </summary>
        [XmlElement("sub_title")]
        public string SubTitle { get; set; }

        /// <summary>
        /// 产品 标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 优惠券梳理
        /// </summary>
        [XmlElement("voucher_quantity")]
        public long VoucherQuantity { get; set; }
    }
}
