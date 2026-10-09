using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// StandardVoucherOpenApiVO Data Structure.
    /// </summary>
    [Serializable]
    public class StandardVoucherOpenApiVO : AopObject
    {
        /// <summary>
        /// 是否有算法打标推荐值
        /// </summary>
        [XmlElement("algorithm_tag")]
        public string AlgorithmTag { get; set; }

        /// <summary>
        /// 账户余额
        /// </summary>
        [XmlElement("balance")]
        public MultiCurrencyMoneyOpenApi Balance { get; set; }

        /// <summary>
        /// 收费金额
        /// </summary>
        [XmlElement("charge_amount")]
        public MultiCurrencyMoneyOpenApi ChargeAmount { get; set; }

        /// <summary>
        /// COA扩展属性，json格式
        /// </summary>
        [XmlElement("coa_properties")]
        public string CoaProperties { get; set; }

        /// <summary>
        /// 数仓dt
        /// </summary>
        [XmlElement("dt")]
        public string Dt { get; set; }

        /// <summary>
        /// 数仓流水类型：当日银行流水(BANK_CURRENT)，历史银行流水(HISTORY_BANK)，当日支付宝流水(ALIPAY_CURRENT)，历史支付宝流水(ALIPAY_HISTORY)
        /// </summary>
        [XmlElement("dw_log_type")]
        public string DwLogType { get; set; }

        /// <summary>
        /// 业务事件码
        /// </summary>
        [XmlElement("event_code")]
        public string EventCode { get; set; }

        /// <summary>
        /// 扩展属性
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
        /// 创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 处理结果状态，10-系统处理中，20-未明，30-线下平台已入账，40-其他平台已入账，50-业务平台入账成功
        /// </summary>
        [XmlElement("handle_status")]
        public string HandleStatus { get; set; }

        /// <summary>
        /// 数仓hour
        /// </summary>
        [XmlElement("hour")]
        public string Hour { get; set; }

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
        /// 原始流水号：机构流水号
        /// </summary>
        [XmlElement("inst_serial_no")]
        public string InstSerialNo { get; set; }

        /// <summary>
        /// 人工打标备注
        /// </summary>
        [XmlElement("manual_dist_demo")]
        public string ManualDistDemo { get; set; }

        /// <summary>
        /// 人工打标类型
        /// </summary>
        [XmlElement("manual_dist_type")]
        public string ManualDistType { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 操作员
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 原始流水号
        /// </summary>
        [XmlElement("org_trans_no")]
        public string OrgTransNo { get; set; }

        /// <summary>
        /// 原始交易金额
        /// </summary>
        [XmlElement("ori_trans_amount")]
        public MultiCurrencyMoneyOpenApi OriTransAmount { get; set; }

        /// <summary>
        /// 原始交易汇率
        /// </summary>
        [XmlElement("ori_trans_rate")]
        public string OriTransRate { get; set; }

        /// <summary>
        /// 对方账户信息
        /// </summary>
        [XmlElement("other_account")]
        public AccountInfoVO OtherAccount { get; set; }

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
        /// 关联凭证ID
        /// </summary>
        [XmlElement("rel_voucher_id")]
        public string RelVoucherId { get; set; }

        /// <summary>
        /// 凭证状态，01-初始，02-已识别，03-业务平台处理中，04-已处理，05-冲销中，06-已冲销，07-人工待处理，08-人工处理中，09-已作废，10-未明到通用登账中
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 目标账户信息
        /// </summary>
        [XmlElement("target_account")]
        public AccountInfoVO TargetAccount { get; set; }

        /// <summary>
        /// 租户ID
        /// </summary>
        [XmlElement("tnt_inst_id")]
        public string TntInstId { get; set; }

        /// <summary>
        /// 账户信息
        /// </summary>
        [XmlElement("trans_account")]
        public AccountInfoVO TransAccount { get; set; }

        /// <summary>
        /// 交易金额
        /// </summary>
        [XmlElement("trans_amount")]
        public MultiCurrencyMoneyOpenApi TransAmount { get; set; }

        /// <summary>
        /// 借贷方向；借：DEBIT;贷：CREDIT
        /// </summary>
        [XmlElement("trans_direction")]
        public string TransDirection { get; set; }

        /// <summary>
        /// 交易时间
        /// </summary>
        [XmlElement("trans_dt")]
        public string TransDt { get; set; }

        /// <summary>
        /// 机构ID，Z50、K53等等，非空
        /// </summary>
        [XmlElement("trans_inst_id")]
        public string TransInstId { get; set; }

        /// <summary>
        /// 主事务id,用于凭证勾兑,当前内部户勾兑使用
        /// </summary>
        [XmlElement("tx_id")]
        public string TxId { get; set; }

        /// <summary>
        /// 凭证类型，ALIPAY-支付宝，BANK-银行
        /// </summary>
        [XmlElement("voucher_type")]
        public string VoucherType { get; set; }

        /// <summary>
        /// 关联冲销凭证ID
        /// </summary>
        [XmlElement("writeoff_voucher_id")]
        public string WriteoffVoucherId { get; set; }
    }
}
