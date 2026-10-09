using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BusinessRelationShopTradeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BusinessRelationShopTradeInfo : AopObject
    {
        /// <summary>
        /// 商业关系物理门店id
        /// </summary>
        [XmlElement("real_shop_id")]
        public string RealShopId { get; set; }

        /// <summary>
        /// 商业关系门店编号
        /// </summary>
        [XmlElement("real_shop_no")]
        public string RealShopNo { get; set; }

        /// <summary>
        /// 门店确权状态，READY、PENDING两种状态
        /// </summary>
        [XmlElement("shop_confirm_status")]
        public string ShopConfirmStatus { get; set; }

        /// <summary>
        /// 门店名称
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 门店经营数据信息
        /// </summary>
        [XmlElement("shop_trade_data_info")]
        public BusinessRelationTradeInfo ShopTradeDataInfo { get; set; }
    }
}
