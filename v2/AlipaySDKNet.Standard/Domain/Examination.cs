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
        /// 1 用户主动取消订单 2 未支付自动取消 3 商家超时未接单自动取消 4 用户补方超时自动取消 5 医生拒方取消订单 6 医生开方超时自动取消（处方侧） 7 医生开方超时自动取消（订单侧） 8 药店审方驳回取消订单 9 药店审方超时自动取消订单（处方侧） 10 药店审方超时自动取消订单（订单侧） 11 处方已作废
        /// </summary>
        [XmlElement("cancel_type")]
        public long CancelType { get; set; }

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
        /// 订单金额信息
        /// </summary>
        [XmlElement("order_amount_info")]
        public OrderAmountInfo OrderAmountInfo { get; set; }

        /// <summary>
        /// SAAS的订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 就诊人信息
        /// </summary>
        [XmlArray("patient_infos")]
        [XmlArrayItem("patient_info_for_fulfillment_list")]
        public List<PatientInfoForFulfillmentList> PatientInfos { get; set; }

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
