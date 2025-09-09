using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalIndustrydataDrugorderSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalIndustrydataDrugorderSyncModel : AopObject
    {
        /// <summary>
        /// 增值服务信息
        /// </summary>
        [XmlArray("add_services")]
        [XmlArrayItem("add_services_info")]
        public List<AddServicesInfo> AddServices { get; set; }

        /// <summary>
        /// 支付宝用户openId
        /// </summary>
        [XmlElement("alipay_open_id")]
        public string AlipayOpenId { get; set; }

        /// <summary>
        /// 支付宝问诊单id
        /// </summary>
        [XmlElement("alipay_order_id")]
        public string AlipayOrderId { get; set; }

        /// <summary>
        /// 支付宝处方订单id
        /// </summary>
        [XmlElement("alipay_prescription_id")]
        public string AlipayPrescriptionId { get; set; }

        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 订单备注
        /// </summary>
        [XmlElement("comments")]
        public string Comments { get; set; }

        /// <summary>
        /// 药品列表
        /// </summary>
        [XmlArray("drug_list")]
        [XmlArrayItem("platform_drug_info")]
        public List<PlatformDrugInfo> DrugList { get; set; }

        /// <summary>
        /// 订单创建时间
        /// </summary>
        [XmlElement("drug_order_create_time")]
        public string DrugOrderCreateTime { get; set; }

        /// <summary>
        /// 订单支付时间
        /// </summary>
        [XmlElement("drug_order_pay_time")]
        public string DrugOrderPayTime { get; set; }

        /// <summary>
        /// 应付订单金额
        /// </summary>
        [XmlElement("drug_order_price")]
        public string DrugOrderPrice { get; set; }

        /// <summary>
        /// 实付订单金额
        /// </summary>
        [XmlElement("drug_order_price_real")]
        public string DrugOrderPriceReal { get; set; }

        /// <summary>
        /// 订单来源  线上订单 ONLINE/线下订单 OFFLINE
        /// </summary>
        [XmlElement("drug_order_source")]
        public string DrugOrderSource { get; set; }

        /// <summary>
        /// 药品订单状态：待发货状态时同步药品订单信息
        /// </summary>
        [XmlElement("drug_order_status")]
        public string DrugOrderStatus { get; set; }

        /// <summary>
        /// 外部平台用户id
        /// </summary>
        [XmlElement("merchant_user_id")]
        public string MerchantUserId { get; set; }

        /// <summary>
        /// 外部药品订单id
        /// </summary>
        [XmlElement("out_drug_order_id")]
        public string OutDrugOrderId { get; set; }

        /// <summary>
        /// 外部药品单跳转链接
        /// </summary>
        [XmlElement("out_drug_order_url")]
        public string OutDrugOrderUrl { get; set; }

        /// <summary>
        /// 外部问诊单id
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 外部处方订单id
        /// </summary>
        [XmlElement("out_prescription_id")]
        public string OutPrescriptionId { get; set; }

        /// <summary>
        /// 药店id
        /// </summary>
        [XmlElement("pharmacy_id")]
        public string PharmacyId { get; set; }

        /// <summary>
        /// 药店名称
        /// </summary>
        [XmlElement("pharmacy_name")]
        public string PharmacyName { get; set; }

        /// <summary>
        /// 外部平台编号
        /// </summary>
        [XmlElement("platform_code")]
        public string PlatformCode { get; set; }

        /// <summary>
        /// 收货人地址
        /// </summary>
        [XmlElement("receiver_address")]
        public string ReceiverAddress { get; set; }

        /// <summary>
        /// 收货人姓名
        /// </summary>
        [XmlElement("receiver_name")]
        public string ReceiverName { get; set; }

        /// <summary>
        /// 收货人手机号
        /// </summary>
        [XmlElement("receiver_phone")]
        public string ReceiverPhone { get; set; }
    }
}
