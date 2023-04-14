using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// StandardVoucherMultipleConditionQueryRequest Data Structure.
    /// </summary>
    [Serializable]
    public class StandardVoucherMultipleConditionQueryRequest : AopObject
    {
        /// <summary>
        /// 本方账户别名:支付宝为email或手机号，企业账户基本无手机号注册情况
        /// </summary>
        [XmlElement("account_alias_name")]
        public string AccountAliasName { get; set; }

        /// <summary>
        /// 本方账号
        /// </summary>
        [XmlArray("account_no_list")]
        [XmlArrayItem("string")]
        public List<string> AccountNoList { get; set; }

        /// <summary>
        /// 是否有算法打标推荐值
        /// </summary>
        [XmlElement("algorithm_tag")]
        public string AlgorithmTag { get; set; }

        /// <summary>
        /// 黑名单账号，在gffund中添加
        /// </summary>
        [XmlArray("black_trans_account_no_list")]
        [XmlArrayItem("string")]
        public List<string> BlackTransAccountNoList { get; set; }

        /// <summary>
        /// 黑名单机构ID，Z50、K53等等，在gffund中添加
        /// </summary>
        [XmlArray("black_trans_inst_id_list")]
        [XmlArrayItem("string")]
        public List<string> BlackTransInstIdList { get; set; }

        /// <summary>
        /// 当前页码，非空，从1开始
        /// </summary>
        [XmlElement("cur_page")]
        public string CurPage { get; set; }

        /// <summary>
        /// 环境标识，包括PROD，PRE
        /// </summary>
        [XmlElement("env")]
        public string Env { get; set; }

        /// <summary>
        /// 资金业务码list
        /// </summary>
        [XmlArray("fund_biz_code_list")]
        [XmlArrayItem("string")]
        public List<string> FundBizCodeList { get; set; }

        /// <summary>
        /// 处理结果状态，10-系统处理中，20-未明，30-线下平台已入账，40-其他平台已入账，50-业务平台入账成功
        /// </summary>
        [XmlArray("handle_status_list")]
        [XmlArrayItem("string")]
        public List<string> HandleStatusList { get; set; }

        /// <summary>
        /// 原始流水号：机构流水号
        /// </summary>
        [XmlElement("inst_serial_no")]
        public string InstSerialNo { get; set; }

        /// <summary>
        /// 人工识别备注
        /// </summary>
        [XmlElement("manual_dist_memo")]
        public string ManualDistMemo { get; set; }

        /// <summary>
        /// 人工识别类型
        /// </summary>
        [XmlArray("manual_dist_type_list")]
        [XmlArrayItem("string")]
        public List<string> ManualDistTypeList { get; set; }

        /// <summary>
        /// 备注: 模糊查询匹配
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 原始流水号：银行为银行流水号，支付宝为主账务logId
        /// </summary>
        [XmlElement("org_trans_no")]
        public string OrgTransNo { get; set; }

        /// <summary>
        /// 对方账户别名：支付宝为email或手机号
        /// </summary>
        [XmlElement("other_account_alias_name")]
        public string OtherAccountAliasName { get; set; }

        /// <summary>
        /// 对方账号名称，前缀模糊查询匹配
        /// </summary>
        [XmlElement("other_account_name")]
        public string OtherAccountName { get; set; }

        /// <summary>
        /// 对方账号
        /// </summary>
        [XmlElement("other_account_no")]
        public string OtherAccountNo { get; set; }

        /// <summary>
        /// 页大小，非空，最大100，下载分页大小50000
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 查询系统来源, QuerySourceEnum：GFCENTER,GFTMS,ZMGFCENTER,GFBRMP
        /// </summary>
        [XmlElement("query_source")]
        public string QuerySource { get; set; }

        /// <summary>
        /// 排序方式：ASC，DESC。默认升序
        /// </summary>
        [XmlElement("sort_type")]
        public string SortType { get; set; }

        /// <summary>
        /// 凭证状态，01-初始，02-已识别，03-业务平台处理中，04-已处理，05-冲销中，06-已冲销，07-人工待处理，08-人工处理中，09-已作废，10-未明到通用登账中
        /// </summary>
        [XmlArray("status_list")]
        [XmlArrayItem("string")]
        public List<string> StatusList { get; set; }

        /// <summary>
        /// 租户
        /// </summary>
        [XmlElement("tnt_inst_id")]
        public string TntInstId { get; set; }

        /// <summary>
        /// 交易金额：注意只会查询金额大小不会去查询对应的币种
        /// </summary>
        [XmlElement("trans_amount")]
        public MultiCurrencyMoney TransAmount { get; set; }

        /// <summary>
        /// 交易币种
        /// </summary>
        [XmlElement("trans_currency")]
        public string TransCurrency { get; set; }

        /// <summary>
        /// 借贷方向；借：DEBIT;贷：CREDIT
        /// </summary>
        [XmlArray("trans_direction_list")]
        [XmlArrayItem("string")]
        public List<string> TransDirectionList { get; set; }

        /// <summary>
        /// 交易结束日期，非空，交易开始时间和结束时间不能跨月，格式：yyyyMMdd
        /// </summary>
        [XmlElement("trans_end")]
        public string TransEnd { get; set; }

        /// <summary>
        /// 机构ID，Z50、K53等等
        /// </summary>
        [XmlArray("trans_inst_id_list")]
        [XmlArrayItem("string")]
        public List<string> TransInstIdList { get; set; }

        /// <summary>
        /// 交易开始日期，非空，交易开始时间和结束时间不能跨月，格式：yyyyMMdd
        /// </summary>
        [XmlElement("trans_start")]
        public string TransStart { get; set; }

        /// <summary>
        /// 凭证类型，非空， 参考：VoucherTypeEnum， BANK银行流水，INNERACCOUNT内部户流水，ALIPAY支付宝流水，LETTEROFCREDIT信用证流水
        /// </summary>
        [XmlElement("voucher_type")]
        public string VoucherType { get; set; }
    }
}
