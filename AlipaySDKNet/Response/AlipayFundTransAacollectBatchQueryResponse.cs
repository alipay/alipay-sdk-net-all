using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundTransAacollectBatchQueryResponse.
    /// </summary>
    public class AlipayFundTransAacollectBatchQueryResponse : AopResponse
    {
        /// <summary>
        /// 批次说明
        /// </summary>
        [XmlElement("batch_memo")]
        public string BatchMemo { get; set; }

        /// <summary>
        /// 批次号
        /// </summary>
        [XmlElement("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// 批次状态       * INAVAILABLE：系统异常       * AVAILABLE：可付款       * SUCCESS：所有的单据创建成功并且都付款成功       * TIMEOUT：已过期（时间过期且未成功的批次均返回TIMEOUT）       * STOP：停止收款（用户主动停止收款，且批次未过期时返回STOP）
        /// </summary>
        [XmlElement("batch_status")]
        public string BatchStatus { get; set; }

        /// <summary>
        /// 业务类型,客户端透传给收银台。默认值：biz_account_transfer
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 批次创建时间
        /// </summary>
        [XmlElement("create_date")]
        public string CreateDate { get; set; }

        /// <summary>
        /// 发起方（收款人）uid
        /// </summary>
        [XmlElement("creater_user_id")]
        public string CreaterUserId { get; set; }

        /// <summary>
        /// 付款明细list
        /// </summary>
        [XmlArray("detail_list")]
        [XmlArrayItem("batch_detail_info")]
        public List<BatchDetailInfo> DetailList { get; set; }

        /// <summary>
        /// 调用方扩充参数
        /// </summary>
        [XmlElement("ext_param")]
        public string ExtParam { get; set; }

        /// <summary>
        /// 已付款明细list
        /// </summary>
        [XmlArray("paid_detail_list")]
        [XmlArrayItem("batch_detail_info")]
        public List<BatchDetailInfo> PaidDetailList { get; set; }

        /// <summary>
        /// 单笔金额，单位为元，有两位小数
        /// </summary>
        [XmlElement("pay_amount_single")]
        public string PayAmountSingle { get; set; }

        /// <summary>
        /// 收款总金额，单位为元，有两位小数
        /// </summary>
        [XmlElement("pay_amount_total")]
        public string PayAmountTotal { get; set; }

        /// <summary>
        /// 收款方看到总金额（不包括自己）例如：100元3个人AA，收款人看到的是33.34*2=66.68
        /// </summary>
        [XmlElement("pay_amount_total_for_receiver")]
        public string PayAmountTotalForReceiver { get; set; }

        /// <summary>
        /// 实际要创建的笔数：AA如果包括自己这里为show_items_total-1，如果不包括自己这里为show_items_total
        /// </summary>
        [XmlElement("real_items_total")]
        public string RealItemsTotal { get; set; }

        /// <summary>
        /// 显示总笔数
        /// </summary>
        [XmlElement("show_items_total")]
        public string ShowItemsTotal { get; set; }

        /// <summary>
        /// 已付总笔数
        /// </summary>
        [XmlElement("success_amount_total")]
        public string SuccessAmountTotal { get; set; }

        /// <summary>
        /// 过期时间值，单位小时
        /// </summary>
        [XmlElement("time_out_value")]
        public string TimeOutValue { get; set; }

        /// <summary>
        /// 未付款明细list
        /// </summary>
        [XmlArray("unpaid_detail_list")]
        [XmlArrayItem("batch_detail_info")]
        public List<BatchDetailInfo> UnpaidDetailList { get; set; }
    }
}
