using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentRoyaltyBillInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class RentRoyaltyBillInfoDTO : AopObject
    {
        /// <summary>
        /// 平台订单号
        /// </summary>
        [XmlElement("biz_order_id")]
        public string BizOrderId { get; set; }

        /// <summary>
        /// 资方名称
        /// </summary>
        [XmlElement("invest_name")]
        public string InvestName { get; set; }

        /// <summary>
        /// 资方pid
        /// </summary>
        [XmlElement("invest_pid")]
        public string InvestPid { get; set; }

        /// <summary>
        /// 商家订单号
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 分账单明细列表
        /// </summary>
        [XmlArray("royalty_detail_list")]
        [XmlArrayItem("rent_royalty_bill_detail_d_t_o")]
        public List<RentRoyaltyBillDetailDTO> RoyaltyDetailList { get; set; }

        /// <summary>
        /// 租赁商用户Id
        /// </summary>
        [XmlElement("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// 商家名称
        /// </summary>
        [XmlElement("seller_name")]
        public string SellerName { get; set; }
    }
}
