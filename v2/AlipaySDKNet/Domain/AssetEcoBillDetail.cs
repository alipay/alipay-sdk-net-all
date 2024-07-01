using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AssetEcoBillDetail Data Structure.
    /// </summary>
    [Serializable]
    public class AssetEcoBillDetail : AopObject
    {
        /// <summary>
        /// 账单主体
        /// </summary>
        [XmlElement("bill_entity")]
        public string BillEntity { get; set; }

        /// <summary>
        /// 账单摘要编号
        /// </summary>
        [XmlElement("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 生态供应商编号
        /// </summary>
        [XmlElement("eco_code")]
        public string EcoCode { get; set; }

        /// <summary>
        /// 生态供应商订单维度账单明细
        /// </summary>
        [XmlArray("eco_order_bill_details")]
        [XmlArrayItem("asset_eco_order_bill_detail")]
        public List<AssetEcoOrderBillDetail> EcoOrderBillDetails { get; set; }

        /// <summary>
        /// 账单月总金额，四舍五入保留两位小数，单位元
        /// </summary>
        [XmlElement("fee_price")]
        public string FeePrice { get; set; }

        /// <summary>
        /// 生态供应商店铺编号
        /// </summary>
        [XmlElement("shop_code")]
        public string ShopCode { get; set; }
    }
}
