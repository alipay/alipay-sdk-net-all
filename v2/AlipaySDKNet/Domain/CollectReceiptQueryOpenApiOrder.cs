using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CollectReceiptQueryOpenApiOrder Data Structure.
    /// </summary>
    [Serializable]
    public class CollectReceiptQueryOpenApiOrder : AopObject
    {
        /// <summary>
        /// 币种
        /// </summary>
        [XmlElement("ccy")]
        public string Ccy { get; set; }

        /// <summary>
        /// 付款渠道，01:支付宝资金渠道，02:银行渠道，12:信用证资金渠道渠道
        /// </summary>
        [XmlArray("channel_list")]
        [XmlArrayItem("string")]
        public List<string> ChannelList { get; set; }

        /// <summary>
        /// 原始流水ID
        /// </summary>
        [XmlElement("channel_log_no")]
        public string ChannelLogNo { get; set; }

        /// <summary>
        /// 收款单收款结束日期 yyyy-MM-dd
        /// </summary>
        [XmlElement("collect_end_date")]
        public string CollectEndDate { get; set; }

        /// <summary>
        /// 收款单收款起始日期 yyyy-MM-dd
        /// </summary>
        [XmlElement("collect_start_date")]
        public string CollectStartDate { get; set; }

        /// <summary>
        /// 机构ID
        /// </summary>
        [XmlArray("inst_id_list")]
        [XmlArrayItem("string")]
        public List<string> InstIdList { get; set; }

        /// <summary>
        /// 页数，默认第1页
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页显示条数，默认每页显示20条
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 收款方账号
        /// </summary>
        [XmlElement("payee_account_no")]
        public string PayeeAccountNo { get; set; }

        /// <summary>
        /// 付款方账号
        /// </summary>
        [XmlElement("payer_account_no")]
        public string PayerAccountNo { get; set; }

        /// <summary>
        /// 付款方PID
        /// </summary>
        [XmlElement("payer_ip_role_id")]
        public string PayerIpRoleId { get; set; }

        /// <summary>
        /// 收款单号(主键ID)
        /// </summary>
        [XmlElement("receipt_no")]
        public string ReceiptNo { get; set; }

        /// <summary>
        /// 收款单来源标识
        /// </summary>
        [XmlArray("source_list")]
        [XmlArrayItem("string")]
        public List<string> SourceList { get; set; }

        /// <summary>
        /// 收款单使用状态
        /// </summary>
        [XmlArray("status_list")]
        [XmlArrayItem("string")]
        public List<string> StatusList { get; set; }
    }
}
