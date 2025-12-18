using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMerchantcardBookingQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMerchantcardBookingQueryModel : AopObject
    {
        /// <summary>
        /// 日期
        /// </summary>
        [XmlElement("booking_end_date")]
        public string BookingEndDate { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("booking_ids")]
        [XmlArrayItem("string")]
        public List<string> BookingIds { get; set; }

        /// <summary>
        /// 查询预约开始日期
        /// </summary>
        [XmlElement("booking_start_date")]
        public string BookingStartDate { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 预约人手机号
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 门店id【必填】
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 预约状态（枚举） pending      预约待确认 confirmed    预约成功（已确认，待履约） completed    履约完成 canceled     预约取消 expired      预约过期（未履约且超过有效期）
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
