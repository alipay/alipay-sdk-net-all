using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankCreditSupplychainFactoringAfterloaninfoSaveModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditSupplychainFactoringAfterloaninfoSaveModel : AopObject
    {
        /// <summary>
        /// 是否激活:  激活 ACTIVATED, 未激活 NOT_ACTIVATE, 其他 OTHER,
        /// </summary>
        [XmlElement("activate_state")]
        public string ActivateState { get; set; }

        /// <summary>
        /// 激活日期 yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("activate_time")]
        public string ActivateTime { get; set; }

        /// <summary>
        /// U享订单号
        /// </summary>
        [XmlElement("biz_order_no")]
        public string BizOrderNo { get; set; }

        /// <summary>
        /// isv支付宝id
        /// </summary>
        [XmlElement("buyer_alipay_id")]
        public string BuyerAlipayId { get; set; }

        /// <summary>
        /// 手机型号、设备名称
        /// </summary>
        [XmlElement("equipment_name")]
        public string EquipmentName { get; set; }

        /// <summary>
        /// 设备唯一识别码、手机imei
        /// </summary>
        [XmlElement("equipment_no")]
        public string EquipmentNo { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        [XmlElement("ext_data")]
        public string ExtData { get; set; }

        /// <summary>
        /// 发票编号
        /// </summary>
        [XmlElement("invoice_number")]
        public string InvoiceNumber { get; set; }

        /// <summary>
        /// 物流单号
        /// </summary>
        [XmlElement("logistics_order_no")]
        public string LogisticsOrderNo { get; set; }

        /// <summary>
        /// 订单状态 : 交易成功 TRADE_SUCCESS, 退款成功 REFUND_SUCCESS, 其它 OTHER,
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 交易订单号
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 预授权冻结时间 yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("preauth_freeze_time")]
        public string PreauthFreezeTime { get; set; }

        /// <summary>
        /// 门店支付宝登录号
        /// </summary>
        [XmlElement("seller_login_id")]
        public string SellerLoginId { get; set; }

        /// <summary>
        /// 门店名称
        /// </summary>
        [XmlElement("store_name")]
        public string StoreName { get; set; }

        /// <summary>
        /// 门店编号
        /// </summary>
        [XmlElement("store_no")]
        public string StoreNo { get; set; }

        /// <summary>
        /// 分期数，6/12/24
        /// </summary>
        [XmlElement("term")]
        public string Term { get; set; }

        /// <summary>
        /// 订单金额 (单位元，保留2位小数)
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }
    }
}
