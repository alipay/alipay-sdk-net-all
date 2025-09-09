using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// StandardVoucherVO Data Structure.
    /// </summary>
    [Serializable]
    public class StandardVoucherVO : AopObject
    {
        /// <summary>
        /// 业务事件码
        /// </summary>
        [XmlElement("event_code")]
        public string EventCode { get; set; }

        /// <summary>
        /// 扩展属性 json对象字符串 Map<String, String>
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 资金业务码
        /// </summary>
        [XmlElement("fund_biz_code")]
        public string FundBizCode { get; set; }

        /// <summary>
        /// 资金业务名称
        /// </summary>
        [XmlElement("fund_biz_name")]
        public string FundBizName { get; set; }

        /// <summary>
        /// 主键ID
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 幂等ID
        /// </summary>
        [XmlElement("idempotent_id")]
        public string IdempotentId { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 业务产品码
        /// </summary>
        [XmlElement("prod_code")]
        public string ProdCode { get; set; }

        /// <summary>
        /// 交易方向:CREDIT/DEBIT
        /// </summary>
        [XmlElement("trans_direction")]
        public string TransDirection { get; set; }

        /// <summary>
        /// 机构ID，Z50、K53等等，非空
        /// </summary>
        [XmlElement("trans_inst_id")]
        public string TransInstId { get; set; }

        /// <summary>
        /// 凭证类型     BANK("BANK", "银行流水"),      INNERACCOUNT("INNERACCOUNT", "内部户流水"),      ALIPAY("ALIPAY", "支付宝流水"),      LETTEROFCREDIT("LETTEROFCREDIT", "信用证流水");
        /// </summary>
        [XmlElement("voucher_type")]
        public string VoucherType { get; set; }
    }
}
