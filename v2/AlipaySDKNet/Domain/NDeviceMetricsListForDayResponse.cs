using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NDeviceMetricsListForDayResponse Data Structure.
    /// </summary>
    [Serializable]
    public class NDeviceMetricsListForDayResponse : AopObject
    {
        /// <summary>
        /// 支付宝金额，单位元
        /// </summary>
        [XmlElement("alipay_amount")]
        public string AlipayAmount { get; set; }

        /// <summary>
        /// 支付宝笔数
        /// </summary>
        [XmlElement("alipay_transaction_count")]
        public long AlipayTransactionCount { get; set; }

        /// <summary>
        /// 点亮标识
        /// </summary>
        [XmlElement("be_lighted_up")]
        public bool BeLightedUp { get; set; }

        /// <summary>
        /// 注册标识
        /// </summary>
        [XmlElement("be_register")]
        public bool BeRegister { get; set; }

        /// <summary>
        /// 开机标识
        /// </summary>
        [XmlElement("be_turnon_device")]
        public bool BeTurnonDevice { get; set; }

        /// <summary>
        /// 门店名称
        /// </summary>
        [XmlElement("binding_location")]
        public string BindingLocation { get; set; }

        /// <summary>
        /// 市编码
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 市名称
        /// </summary>
        [XmlElement("city_name")]
        public string CityName { get; set; }

        /// <summary>
        /// 区编码
        /// </summary>
        [XmlElement("district_code")]
        public string DistrictCode { get; set; }

        /// <summary>
        /// 区名称
        /// </summary>
        [XmlElement("district_name")]
        public string DistrictName { get; set; }

        /// <summary>
        /// 收银员是否打卡
        /// </summary>
        [XmlElement("do_check_in")]
        public bool DoCheckIn { get; set; }

        /// <summary>
        /// 有效开机标识,当日开机大于6h即为有效开机
        /// </summary>
        [XmlElement("effective_turnon_device")]
        public bool EffectiveTurnonDevice { get; set; }

        /// <summary>
        /// nfc是否动销
        /// </summary>
        [XmlElement("has_nfc_trade")]
        public bool HasNfcTrade { get; set; }

        /// <summary>
        /// leads门店名称
        /// </summary>
        [XmlElement("leads_location")]
        public string LeadsLocation { get; set; }

        /// <summary>
        /// leads门店地址
        /// </summary>
        [XmlElement("leads_location_address")]
        public string LeadsLocationAddress { get; set; }

        /// <summary>
        /// 作业人员uid
        /// </summary>
        [XmlElement("leads_worker_id")]
        public string LeadsWorkerId { get; set; }

        /// <summary>
        /// 作业人员名称
        /// </summary>
        [XmlElement("leads_worker_name")]
        public string LeadsWorkerName { get; set; }

        /// <summary>
        /// 点亮时间,单位为秒
        /// </summary>
        [XmlElement("light_up_time")]
        public string LightUpTime { get; set; }

        /// <summary>
        /// 门店地址
        /// </summary>
        [XmlElement("location_address")]
        public string LocationAddress { get; set; }

        /// <summary>
        /// 统计日期
        /// </summary>
        [XmlElement("metrics_date")]
        public string MetricsDate { get; set; }

        /// <summary>
        /// nfc金额，单位元
        /// </summary>
        [XmlElement("nfc_amount")]
        public string NfcAmount { get; set; }

        /// <summary>
        /// nfc笔数
        /// </summary>
        [XmlElement("nfc_transaction_count")]
        public long NfcTransactionCount { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 省编码
        /// </summary>
        [XmlElement("province_code")]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// 省名称
        /// </summary>
        [XmlElement("province_name")]
        public string ProvinceName { get; set; }

        /// <summary>
        /// 退款金额（追溯近60天）  单位元，精确到分
        /// </summary>
        [XmlElement("refund_order_amt")]
        public string RefundOrderAmt { get; set; }

        /// <summary>
        /// 退款笔数（追溯近60天）
        /// </summary>
        [XmlElement("refund_order_cnt")]
        public string RefundOrderCnt { get; set; }

        /// <summary>
        /// 注册时间
        /// </summary>
        [XmlElement("register_time")]
        public string RegisterTime { get; set; }

        /// <summary>
        /// 收货时间
        /// </summary>
        [XmlElement("shipping_time")]
        public string ShippingTime { get; set; }

        /// <summary>
        /// 设备sn
        /// </summary>
        [XmlElement("sn")]
        public string Sn { get; set; }

        /// <summary>
        /// 外部门店号
        /// </summary>
        [XmlElement("store_id")]
        public string StoreId { get; set; }

        /// <summary>
        /// 首次点亮30天内碰交易大于等于2元用户数
        /// </summary>
        [XmlElement("trd_amt_2_n_user_cnt_fromlight_30_d")]
        public string TrdAmt2NUserCntFromlight30D { get; set; }

        /// <summary>
        /// 碰一下用户数，单位为人，日维度已去重
        /// </summary>
        [XmlElement("trd_nfc_device_usercnt")]
        public string TrdNfcDeviceUsercnt { get; set; }
    }
}
