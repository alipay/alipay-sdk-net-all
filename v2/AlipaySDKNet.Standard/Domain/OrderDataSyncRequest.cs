using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OrderDataSyncRequest Data Structure.
    /// </summary>
    [Serializable]
    public class OrderDataSyncRequest : AopObject
    {
        /// <summary>
        /// 业务id，唯一键标识
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 取消类型，由外部传入
        /// </summary>
        [XmlElement("cancel_type")]
        public string CancelType { get; set; }

        /// <summary>
        /// 卡名称
        /// </summary>
        [XmlElement("card_name")]
        public string CardName { get; set; }

        /// <summary>
        /// 卡资产版本号
        /// </summary>
        [XmlElement("card_version")]
        public string CardVersion { get; set; }

        /// <summary>
        /// 来源渠道，由外部传入，标识从哪个渠道来
        /// </summary>
        [XmlElement("channel_type")]
        public string ChannelType { get; set; }

        /// <summary>
        /// 周期卡次数单位，天:DAY，周:WEEK，月:MONTH，季:QUARTER
        /// </summary>
        [XmlElement("count_unit")]
        public string CountUnit { get; set; }

        /// <summary>
        /// 售卖订单创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 扣款计划列表
        /// </summary>
        [XmlArray("deduction_plan_list")]
        [XmlArrayItem("deduction_plan_data_sync_request")]
        public List<DeductionPlanDataSyncRequest> DeductionPlanList { get; set; }

        /// <summary>
        /// 详情页面链接
        /// </summary>
        [XmlElement("detail_url")]
        public string DetailUrl { get; set; }

        /// <summary>
        /// 环境标识，外部传入
        /// </summary>
        [XmlElement("env")]
        public string Env { get; set; }

        /// <summary>
        /// 有效期结束时间
        /// </summary>
        [XmlElement("expired_end_time")]
        public string ExpiredEndTime { get; set; }

        /// <summary>
        /// 有效期开始时间
        /// </summary>
        [XmlElement("expired_start_time")]
        public string ExpiredStartTime { get; set; }

        /// <summary>
        /// 服务提供商PID
        /// </summary>
        [XmlElement("isv_pid")]
        public string IsvPid { get; set; }

        /// <summary>
        /// 商品编码，由外部传入
        /// </summary>
        [XmlElement("item_code")]
        public string ItemCode { get; set; }

        /// <summary>
        /// 卡包实例id，由外部传入
        /// </summary>
        [XmlElement("kabao_id")]
        public string KabaoId { get; set; }

        /// <summary>
        /// 商户名称
        /// </summary>
        [XmlElement("merchant_name")]
        public string MerchantName { get; set; }

        /// <summary>
        /// 商户pid，由外部传入
        /// </summary>
        [XmlElement("merchant_pid")]
        public string MerchantPid { get; set; }

        /// <summary>
        /// 小程序id
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 业务订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 购卡门店id，由外部传入
        /// </summary>
        [XmlElement("order_shop_id")]
        public string OrderShopId { get; set; }

        /// <summary>
        /// 外部单号，由外部传入
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 退卡金额（单位元）
        /// </summary>
        [XmlElement("refund_price")]
        public string RefundPrice { get; set; }

        /// <summary>
        /// 退卡时间
        /// </summary>
        [XmlElement("refund_time")]
        public string RefundTime { get; set; }

        /// <summary>
        /// 卡剩余可使用次数
        /// </summary>
        [XmlElement("remain_count")]
        public long RemainCount { get; set; }

        /// <summary>
        /// 商户smid
        /// </summary>
        [XmlElement("smid")]
        public string Smid { get; set; }

        /// <summary>
        /// 解决方案类型（卡类型）
        /// </summary>
        [XmlElement("solution_type")]
        public string SolutionType { get; set; }

        /// <summary>
        /// 售卖订单状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 总计可使用次数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }

        /// <summary>
        /// 总原价（单位元）
        /// </summary>
        [XmlElement("total_original_price")]
        public string TotalOriginalPrice { get; set; }

        /// <summary>
        /// 总售价（单位元）
        /// </summary>
        [XmlElement("total_sale_price")]
        public string TotalSalePrice { get; set; }

        /// <summary>
        /// 售卖订单更新时间
        /// </summary>
        [XmlElement("update_time")]
        public string UpdateTime { get; set; }

        /// <summary>
        /// 用户id，由外部传入
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
