using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TipIotDeepeyeSnackRecognizePageResVo Data Structure.
    /// </summary>
    [Serializable]
    public class TipIotDeepeyeSnackRecognizePageResVo : AopObject
    {
        /// <summary>
        /// 人机一致率
        /// </summary>
        [XmlElement("corr_rate")]
        public string CorrRate { get; set; }

        /// <summary>
        /// 称重商品识别结果与店员反馈一致的次数
        /// </summary>
        [XmlElement("corr_session_cnt")]
        public long CorrSessionCnt { get; set; }

        /// <summary>
        /// 设备数
        /// </summary>
        [XmlElement("device_cnt")]
        public long DeviceCnt { get; set; }

        /// <summary>
        /// 设备ID
        /// </summary>
        [XmlElement("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 分析维度
        /// </summary>
        [XmlElement("dim")]
        public string Dim { get; set; }

        /// <summary>
        /// 日期
        /// </summary>
        [XmlElement("dt")]
        public string Dt { get; set; }

        /// <summary>
        /// 服务商名称
        /// </summary>
        [XmlElement("isv_name")]
        public string IsvName { get; set; }

        /// <summary>
        /// isvPid字段存储的是服务商id(isvId)，仅用作返回给外部接口
        /// </summary>
        [XmlElement("isv_pid")]
        public string IsvPid { get; set; }

        /// <summary>
        /// 商户数
        /// </summary>
        [XmlElement("merchant_cnt")]
        public long MerchantCnt { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 商户名称
        /// </summary>
        [XmlElement("merchant_name")]
        public string MerchantName { get; set; }

        /// <summary>
        /// 仅一次正确识别的会话数量
        /// </summary>
        [XmlElement("only_1_corr_session_cnt")]
        public long Only1CorrSessionCnt { get; set; }

        /// <summary>
        /// 仅一次识别尝试的会话数量
        /// </summary>
        [XmlElement("only_1_session_cnt")]
        public long Only1SessionCnt { get; set; }

        /// <summary>
        /// AI采纳率
        /// </summary>
        [XmlElement("select_rate")]
        public string SelectRate { get; set; }

        /// <summary>
        /// 称重商品识别结果被店员采纳的次数
        /// </summary>
        [XmlElement("selectai_session_cnt")]
        public long SelectaiSessionCnt { get; set; }

        /// <summary>
        /// 总识别次数
        /// </summary>
        [XmlElement("session_cnt")]
        public long SessionCnt { get; set; }

        /// <summary>
        /// 门店数
        /// </summary>
        [XmlElement("store_cnt")]
        public long StoreCnt { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [XmlElement("store_id")]
        public string StoreId { get; set; }

        /// <summary>
        /// 门店名称
        /// </summary>
        [XmlElement("store_name")]
        public string StoreName { get; set; }

        /// <summary>
        /// 时间粒度
        /// </summary>
        [XmlElement("time_period")]
        public string TimePeriod { get; set; }

        /// <summary>
        /// Top1人机一致率
        /// </summary>
        [XmlElement("top_1_corr_rate")]
        public string Top1CorrRate { get; set; }

        /// <summary>
        /// Top1与店员反馈一致的次数
        /// </summary>
        [XmlElement("top_1_corr_session_cnt")]
        public long Top1CorrSessionCnt { get; set; }

        /// <summary>
        /// 称重商品识别次数
        /// </summary>
        [XmlElement("weigh_session_cnt")]
        public long WeighSessionCnt { get; set; }
    }
}
