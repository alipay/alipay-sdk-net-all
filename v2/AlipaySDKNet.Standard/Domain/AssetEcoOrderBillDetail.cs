using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AssetEcoOrderBillDetail Data Structure.
    /// </summary>
    [Serializable]
    public class AssetEcoOrderBillDetail : AopObject
    {
        /// <summary>
        /// 实际情况下订单结算费用总金额 （单位元，四舍五入两位小数）
        /// </summary>
        [XmlElement("actual_fee_price")]
        public string ActualFeePrice { get; set; }

        /// <summary>
        /// 账单主体
        /// </summary>
        [XmlElement("bill_entity")]
        public string BillEntity { get; set; }

        /// <summary>
        /// 账单状态
        /// </summary>
        [XmlElement("bill_status")]
        public string BillStatus { get; set; }

        /// <summary>
        /// 生态供应商外部订单号交易平台
        /// </summary>
        [XmlElement("busi_platform")]
        public string BusiPlatform { get; set; }

        /// <summary>
        /// 50.40
        /// </summary>
        [XmlElement("correct_fee_price")]
        public string CorrectFeePrice { get; set; }

        /// <summary>
        /// 生态供应商编号
        /// </summary>
        [XmlElement("eco_code")]
        public string EcoCode { get; set; }

        /// <summary>
        /// 生态供应商订单费用明细
        /// </summary>
        [XmlArray("eco_fee_details")]
        [XmlArrayItem("asset_eco_fee_detail")]
        public List<AssetEcoFeeDetail> EcoFeeDetails { get; set; }

        /// <summary>
        /// 供应链平台生态平台订单号
        /// </summary>
        [XmlElement("eco_order_id")]
        public string EcoOrderId { get; set; }

        /// <summary>
        /// 下单时间
        /// </summary>
        [XmlElement("order_date")]
        public string OrderDate { get; set; }

        /// <summary>
        /// 生态供应商外部交易平台订单id
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 生态供应商店铺编号
        /// </summary>
        [XmlElement("shop_code")]
        public string ShopCode { get; set; }

        /// <summary>
        /// 不可结算原因，若bill_status=结算状态UN_BILL，则该项不为空
        /// </summary>
        [XmlElement("unbill_reason")]
        public string UnbillReason { get; set; }
    }
}
