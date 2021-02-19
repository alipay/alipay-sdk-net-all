using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoActivityRecycleSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoActivityRecycleSendModel : AopObject
    {
        /// <summary>
        /// 买家的用户id
        /// </summary>
        [XmlElement("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 清单明细
        /// </summary>
        [XmlArray("item_list")]
        [XmlArrayItem("energy_good_request")]
        public List<EnergyGoodRequest> ItemList { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 外部业务类型
        /// </summary>
        [XmlElement("out_biz_type")]
        public string OutBizType { get; set; }

        /// <summary>
        /// 卖家的用户id
        /// </summary>
        [XmlElement("seller_id")]
        public string SellerId { get; set; }
    }
}
