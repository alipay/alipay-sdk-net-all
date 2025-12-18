using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMerchantcardBookingserviceQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMerchantcardBookingserviceQueryModel : AopObject
    {
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
        /// null
        /// </summary>
        [XmlArray("service_ids")]
        [XmlArrayItem("string")]
        public List<string> ServiceIds { get; set; }

        /// <summary>
        /// 门店id【必填】
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 服务状态（枚举） active       可预约状态 inactive     不可预约，后续可恢复成active
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
