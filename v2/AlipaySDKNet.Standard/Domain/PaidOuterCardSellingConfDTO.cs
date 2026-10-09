using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PaidOuterCardSellingConfDTO Data Structure.
    /// </summary>
    [Serializable]
    public class PaidOuterCardSellingConfDTO : AopObject
    {
        /// <summary>
        /// 售卖结束时间。 格式：yyyy-MM-dd HH:mm:ss 如果永久有效则不传。
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 售卖方案列表
        /// </summary>
        [XmlArray("price_detail")]
        [XmlArrayItem("paid_outer_card_price_detail_d_t_o")]
        public List<PaidOuterCardPriceDetailDTO> PriceDetail { get; set; }

        /// <summary>
        /// 售卖地址
        /// </summary>
        [XmlElement("selling_url")]
        public string SellingUrl { get; set; }

        /// <summary>
        /// 售卖开始时间。格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }
    }
}
