using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossFncGfaccenterConsolidationAcceptModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncGfaccenterConsolidationAcceptModel : AopObject
    {
        /// <summary>
        /// （必填）会计期间（非调整账期yyyyMM，调整账期yyyy-MM），默认为期望并账会计日期前6位
        /// </summary>
        [XmlElement("acc_month")]
        public string AccMonth { get; set; }

        /// <summary>
        /// （必填）是否调整账期(默认非调整账期)
        /// </summary>
        [XmlElement("adjust_period")]
        public bool AdjustPeriod { get; set; }

        /// <summary>
        /// （必填）业务链路
        /// </summary>
        [XmlElement("biz_chain")]
        public string BizChain { get; set; }

        /// <summary>
        /// （必填）业务发生时间（yyyy-MM-dd HH:mm:ss格式）
        /// </summary>
        [XmlElement("biz_date_time")]
        public string BizDateTime { get; set; }

        /// <summary>
        /// （必填）并账业务事件码
        /// </summary>
        [XmlElement("biz_event_code")]
        public string BizEventCode { get; set; }

        /// <summary>
        /// （必填）业务模块
        /// </summary>
        [XmlElement("biz_module")]
        public string BizModule { get; set; }

        /// <summary>
        /// （必填）并账业务产品码
        /// </summary>
        [XmlElement("biz_product_code")]
        public string BizProductCode { get; set; }

        /// <summary>
        /// COA类型，当前蚂蚁为 ANT_ORACLE_GL_50388 存在财会凭证行时必填
        /// </summary>
        [XmlElement("coa_type")]
        public string CoaType { get; set; }

        /// <summary>
        /// 汇率日期（使用用户汇率及本币信息时必填）（yyyyMMdd格式）
        /// </summary>
        [XmlElement("exchange_date")]
        public string ExchangeDate { get; set; }

        /// <summary>
        /// 汇率（使用用户汇率及本币信息时必填）
        /// </summary>
        [XmlElement("exchange_rate")]
        public string ExchangeRate { get; set; }

        /// <summary>
        /// 汇率类型（使用用户汇率及本币信息时必填）
        /// </summary>
        [XmlElement("exchange_type")]
        public string ExchangeType { get; set; }

        /// <summary>
        /// （必填）期望并账会计日期（yyyyMMdd格式）
        /// </summary>
        [XmlElement("expect_account_date")]
        public string ExpectAccountDate { get; set; }

        /// <summary>
        /// （必填）凭证日记账描述（长度限制：240个字节，汉字3个字节）
        /// </summary>
        [XmlElement("je_desc")]
        public string JeDesc { get; set; }

        /// <summary>
        /// (必填）凭证行信息列表
        /// </summary>
        [XmlArray("je_lines")]
        [XmlArrayItem("gfac_consolidation_entry_line_d_t_o")]
        public List<GfacConsolidationEntryLineDTO> JeLines { get; set; }

        /// <summary>
        /// 凭证日记账名称（长度限制：100个字节，汉字3个字节,为空默认用模块链路设置日记账名称）
        /// </summary>
        [XmlElement("je_name")]
        public string JeName { get; set; }

        /// <summary>
        /// （必填）凭证日记账编号（幂等维度2）
        /// </summary>
        [XmlElement("je_no")]
        public string JeNo { get; set; }

        /// <summary>
        /// 并账描述信息，非必填字段，用于描述说明
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// （必填）原币币种编码（如CNY、USD）
        /// </summary>
        [XmlElement("orig_currency_code")]
        public string OrigCurrencyCode { get; set; }

        /// <summary>
        /// （必填）核算机构
        /// </summary>
        [XmlElement("recon_inst")]
        public string ReconInst { get; set; }

        /// <summary>
        /// 本币币种编码（使用用户汇率及本币信息时必填）
        /// </summary>
        [XmlElement("sob_currency_code")]
        public string SobCurrencyCode { get; set; }

        /// <summary>
        /// （必填）账套类型(默认PRIMARY)
        /// </summary>
        [XmlElement("sob_type")]
        public string SobType { get; set; }

        /// <summary>
        /// （必填）来源系统（幂等维度1）
        /// </summary>
        [XmlElement("src_app")]
        public string SrcApp { get; set; }

        /// <summary>
        /// 登账人工号，非必填
        /// </summary>
        [XmlElement("submitter")]
        public string Submitter { get; set; }

        /// <summary>
        /// （必填）是否使用用户汇率及本币信息，如果为true需要填本币信息和汇率信息，false则系统自动处理
        /// </summary>
        [XmlElement("use_user_rate_info")]
        public bool UseUserRateInfo { get; set; }
    }
}
