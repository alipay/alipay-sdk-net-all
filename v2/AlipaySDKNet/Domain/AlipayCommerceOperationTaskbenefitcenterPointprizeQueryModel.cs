using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceOperationTaskbenefitcenterPointprizeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceOperationTaskbenefitcenterPointprizeQueryModel : AopObject
    {
        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 优惠卷
        /// </summary>
        [XmlElement("prize_type")]
        public string PrizeType { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
