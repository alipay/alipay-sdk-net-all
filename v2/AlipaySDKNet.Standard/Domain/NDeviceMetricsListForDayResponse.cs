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
        /// 设备连接电脑系统类型
        /// </summary>
        [XmlElement("device_system")]
        public string DeviceSystem { get; set; }

        /// <summary>
        /// 设备类型
        /// </summary>
        [XmlElement("device_type")]
        public string DeviceType { get; set; }

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
        /// 设备碰一下或扫码交易大于等于2元的支付笔数且一个用户同一天交易笔数最多为2笔
        /// </summary>
        [XmlElement("effective_alipay_transaction_count")]
        public string EffectiveAlipayTransactionCount { get; set; }

        /// <summary>
        /// 设备碰一下交易大于等于2元的支付笔数且一个用户同一天交易笔数最多为2笔
        /// </summary>
        [XmlElement("effective_nfc_transaction_count")]
        public string EffectiveNfcTransactionCount { get; set; }

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
        /// 设备当日至少有一笔碰一下且交易金额大于等于2元，则为是
        /// </summary>
        [XmlElement("has_nfc_trade_greater_2")]
        public bool HasNfcTradeGreater2 { get; set; }

        /// <summary>
        /// 点亮30天内打卡天数
        /// </summary>
        [XmlElement("last_30_checkin_days")]
        public string Last30CheckinDays { get; set; }

        /// <summary>
        /// 点亮30天内动销≥2元天数
        /// </summary>
        [XmlElement("last_30_sales_over_2_days")]
        public string Last30SalesOver2Days { get; set; }

        /// <summary>
        /// 点亮30天内有效开机天数
        /// </summary>
        [XmlElement("last_30_valid_boot_days")]
        public string Last30ValidBootDays { get; set; }

        /// <summary>
        /// 点亮7天内打卡天数
        /// </summary>
        [XmlElement("last_7_checkin_days")]
        public string Last7CheckinDays { get; set; }

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
        /// 近7天小指令有活跃，不区分saas、免研小指令
        /// </summary>
        [XmlElement("micro_command_active_7_day")]
        public bool MicroCommandActive7Day { get; set; }

        /// <summary>
        /// nfc金额，单位元
        /// </summary>
        [XmlElement("nfc_amount")]
        public string NfcAmount { get; set; }

        /// <summary>
        /// 设备当日至少有一笔碰一下或扫码交易且交易金额大于等于2元，则为是
        /// </summary>
        [XmlElement("nfc_trade_greater_2")]
        public bool NfcTradeGreater2 { get; set; }

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
        /// 设备在统计当天所产生的用户碰一下实付金额总额（限定交易时间在统计当日） 单位元，精确到分
        /// </summary>
        [XmlElement("real_consume_fee")]
        public string RealConsumeFee { get; set; }

        /// <summary>
        /// 设备在统计当天所发生的nfc交易实付退款金额（仅限定退款时间在当日）单位元，精确到分
        /// </summary>
        [XmlElement("real_refund_fee")]
        public string RealRefundFee { get; set; }

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
        /// 最新门店首次大于等于1元动销时间
        /// </summary>
        [XmlElement("store_first_sale_1_yuan_date")]
        public string StoreFirstSale1YuanDate { get; set; }

        /// <summary>
        /// 外部门店号
        /// </summary>
        [XmlElement("store_id")]
        public string StoreId { get; set; }

        /// <summary>
        /// 累计已点亮自然月
        /// </summary>
        [XmlElement("total_lighted_months")]
        public string TotalLightedMonths { get; set; }

        /// <summary>
        /// 首次点亮30天内碰交易大于等于2元用户数
        /// </summary>
        [XmlElement("trd_amt_2_n_user_cnt_fromlight_30_d")]
        public string TrdAmt2NUserCntFromlight30D { get; set; }

        /// <summary>
        /// 大于等于2元碰一下交易的用户数，单位为人，日维度去重
        /// </summary>
        [XmlElement("trd_greater_2_nfc_device_usercnt")]
        public string TrdGreater2NfcDeviceUsercnt { get; set; }

        /// <summary>
        /// 碰一下用户数，单位为人，日维度已去重
        /// </summary>
        [XmlElement("trd_nfc_device_usercnt")]
        public string TrdNfcDeviceUsercnt { get; set; }

        /// <summary>
        /// 设备最近绑定门店的时间
        /// </summary>
        [XmlElement("update_register_time")]
        public string UpdateRegisterTime { get; set; }
    }
}
