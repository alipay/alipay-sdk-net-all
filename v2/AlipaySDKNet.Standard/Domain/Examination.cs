using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Examination Data Structure.
    /// </summary>
    [Serializable]
    public class Examination : AopObject
    {
        /// <summary>
        /// 应用id
        /// </summary>
        [XmlElement("application_id")]
        public string ApplicationId { get; set; }

        /// <summary>
        /// 预约信息
        /// </summary>
        [XmlElement("book_info")]
        public ExaminationBookInfo BookInfo { get; set; }

        /// <summary>
        /// 检测信息
        /// </summary>
        [XmlElement("check_info")]
        public ExaminationCheckInfo CheckInfo { get; set; }

        /// <summary>
        /// 收货信息
        /// </summary>
        [XmlElement("deliver_info")]
        public ExaminationDeliverInfo DeliverInfo { get; set; }

        /// <summary>
        /// 履约状态，非枚举。
        /// </summary>
        [XmlElement("fulfillment_status")]
        public string FulfillmentStatus { get; set; }

        /// <summary>
        /// 商品信息列表
        /// </summary>
        [XmlArray("items")]
        [XmlArrayItem("examination_item_v_o")]
        public List<ExaminationItemVO> Items { get; set; }

        /// <summary>
        /// SAAS的订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 支付信息
        /// </summary>
        [XmlElement("pay_info")]
        public ExaminationPayInfo PayInfo { get; set; }

        /// <summary>
        /// 外部履约单号
        /// </summary>
        [XmlElement("relation_order_no")]
        public string RelationOrderNo { get; set; }

        /// <summary>
        /// 商家ID
        /// </summary>
        [XmlElement("seller_code")]
        public string SellerCode { get; set; }

        /// <summary>
        /// 来源
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 门店编码
        /// </summary>
        [XmlElement("store_code")]
        public string StoreCode { get; set; }

        /// <summary>
        /// 门店id
        /// </summary>
        [XmlElement("store_id")]
        public string StoreId { get; set; }

        /// <summary>
        /// 门店名称
        /// </summary>
        [XmlElement("store_name")]
        public string StoreName { get; set; }

        /// <summary>
        /// 履约单编号
        /// </summary>
        [XmlElement("unique_no")]
        public string UniqueNo { get; set; }
    }
}
