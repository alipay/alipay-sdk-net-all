using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundBatchCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundBatchCreateModel : AopObject
    {
        /// <summary>
        /// 业务场景。不同场景值不同，具体值联系支付宝确认
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// JSON格式，传递业务扩展参数。
        /// </summary>
        [XmlElement("business_params")]
        public string BusinessParams { get; set; }

        /// <summary>
        /// 转账标题，用于收银台展示标题
        /// </summary>
        [XmlElement("order_title")]
        public string OrderTitle { get; set; }

        /// <summary>
        /// 商户的批次号
        /// </summary>
        [XmlElement("out_batch_no")]
        public string OutBatchNo { get; set; }

        /// <summary>
        /// 公用回传参数，如果请求时传递了该参数，则异步通知商户时会回传该参数。
        /// </summary>
        [XmlElement("passback_params")]
        public string PassbackParams { get; set; }

        /// <summary>
        /// 付款方信息
        /// </summary>
        [XmlElement("payer_info")]
        public Participant PayerInfo { get; set; }

        /// <summary>
        /// 业务产品码。不同产品值不同，具体值联系支付宝确认。
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 转账备注
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 绝对超时时间，格式为yyyy-MM-dd HH:mm。
        /// </summary>
        [XmlElement("time_expire")]
        public string TimeExpire { get; set; }

        /// <summary>
        /// 批次总笔数
        /// </summary>
        [XmlElement("total_count")]
        public string TotalCount { get; set; }

        /// <summary>
        /// 批次总金额，单位为元，精确到小数点后两位，取值范围[1.00,9999999999999.99]
        /// </summary>
        [XmlElement("total_trans_amount")]
        public string TotalTransAmount { get; set; }

        /// <summary>
        /// 收款信息列表。实际集合可以添加多个收款方信息，最多可以添加1000个收款方信息，如方案接入文档有特别说明，优先以接入文档为准
        /// </summary>
        [XmlArray("trans_order_list")]
        [XmlArrayItem("trans_order_detail")]
        public List<TransOrderDetail> TransOrderList { get; set; }

        /// <summary>
        /// 该笔转账使用的转账场景，商户可前往【<a href="https://b.alipay.com/page/bizfund/transferScene/list">支付宝商家平台-资金管理-转账场景</a>】中查看/申明转账场景。<br> 目前支持以下枚举值：现金营销、企业退款、佣金报酬、业务结算、二手回收、公益补助、行政补贴和退款、保险理赔
        /// </summary>
        [XmlElement("transfer_scene_name")]
        public string TransferSceneName { get; set; }

        /// <summary>
        /// 转账场景信息，包含转账场景信息类型和转账场景信息描述。需按该笔转账使用的转账场景准确填写
        /// </summary>
        [XmlArray("transfer_scene_report_infos")]
        [XmlArrayItem("transfer_scene_report_info")]
        public List<TransferSceneReportInfo> TransferSceneReportInfos { get; set; }
    }
}
