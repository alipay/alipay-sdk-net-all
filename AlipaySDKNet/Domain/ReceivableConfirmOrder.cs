using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ReceivableConfirmOrder Data Structure.
    /// </summary>
    [Serializable]
    public class ReceivableConfirmOrder : AopObject
    {
        /// <summary>
        /// 合约号
        /// </summary>
        [XmlElement("ar_no")]
        public string ArNo { get; set; }

        /// <summary>
        /// 合约体系来源
        /// </summary>
        [XmlElement("ar_source")]
        public string ArSource { get; set; }

        /// <summary>
        /// 确认周期开始时间
        /// </summary>
        [XmlElement("begin_date")]
        public string BeginDate { get; set; }

        /// <summary>
        /// 二级业务识别信息
        /// </summary>
        [XmlElement("business_recognize_ext")]
        public MapParameter BusinessRecognizeExt { get; set; }

        /// <summary>
        /// 周期确认扩展计算因子
        /// </summary>
        [XmlElement("calc_factor")]
        public string CalcFactor { get; set; }

        /// <summary>
        /// 周期确认应收计算方法
        /// </summary>
        [XmlElement("calc_method")]
        public string CalcMethod { get; set; }

        /// <summary>
        /// 确认应收周期
        /// </summary>
        [XmlElement("calc_period")]
        public string CalcPeriod { get; set; }

        /// <summary>
        /// 应收确认模式，支持一次性和周期性确认
        /// </summary>
        [XmlElement("confirm_model")]
        public string ConfirmModel { get; set; }

        /// <summary>
        /// 周期确认结束时间
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlArray("ext_info")]
        [XmlArrayItem("map_parameter")]
        public List<MapParameter> ExtInfo { get; set; }

        /// <summary>
        /// 业务完成时间
        /// </summary>
        [XmlElement("gmt_service")]
        public string GmtService { get; set; }

        /// <summary>
        /// 核算主体代码
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 核算主体ID
        /// </summary>
        [XmlElement("ip_id")]
        public string IpId { get; set; }

        /// <summary>
        /// 商户角色ID，即PID
        /// </summary>
        [XmlElement("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// 业务请求号，用于幂等校验
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 业务产品码
        /// </summary>
        [XmlElement("pd_code")]
        public string PdCode { get; set; }

        /// <summary>
        /// 产品事件码
        /// </summary>
        [XmlElement("pd_event_code")]
        public string PdEventCode { get; set; }

        /// <summary>
        /// 产品体系来源
        /// </summary>
        [XmlElement("pd_source")]
        public string PdSource { get; set; }

        /// <summary>
        /// 应收金额
        /// </summary>
        [XmlElement("receivable_amount")]
        public MultiCurrencyMoneyOpenApi ReceivableAmount { get; set; }

        /// <summary>
        /// 应收单类型，支持普通和调整两类
        /// </summary>
        [XmlElement("receivable_type")]
        public string ReceivableType { get; set; }

        /// <summary>
        /// 调用方系统名
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 用户体系来源
        /// </summary>
        [XmlElement("user_source")]
        public string UserSource { get; set; }
    }
}
