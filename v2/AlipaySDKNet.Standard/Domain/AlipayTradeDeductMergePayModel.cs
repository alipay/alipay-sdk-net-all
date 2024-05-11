using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeDeductMergePayModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeDeductMergePayModel : AopObject
    {
        /// <summary>
        /// 用户与商户的协议信息
        /// </summary>
        [XmlElement("agreement_params")]
        public AgreementParams AgreementParams { get; set; }

        /// <summary>
        /// scene对应的场景值授权码，比如ZMOP12345
        /// </summary>
        [XmlElement("auth_code")]
        public string AuthCode { get; set; }

        /// <summary>
        /// 子订单详情
        /// </summary>
        [XmlArray("order_details")]
        [XmlArrayItem("order_detail")]
        public List<OrderDetail> OrderDetails { get; set; }

        /// <summary>
        /// 外部合并订单号
        /// </summary>
        [XmlElement("out_merge_no")]
        public string OutMergeNo { get; set; }

        /// <summary>
        /// 协议场景信息：比如芝麻先享
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 订单绝对超时时间。 格式为yyyy-MM-dd HH:mm:ss。 注： 1. 如果已经和支付宝约定要求子订单明细必须同时成功同时失败，则不需要填入该字段，默认为15分钟，此场景下如果需要支持自定义超时时间，请联系技术小二。 2. time_expire和timeout_express两者只需传入一个或者都不传，两者均传入时，优先使用time_expire。
        /// </summary>
        [XmlElement("time_expire")]
        public string TimeExpire { get; set; }

        /// <summary>
        /// 合并支付订单相对超时时间。从商户合并下单请求时间开始计算。 请求合并的所有订单允许的最晚付款时间，逾期将关闭交易。取值范围：1m～15d。m-分钟，h-小时，d-天，1c-当天（1c-当天的情况下，无论交易何时创建，都在0点关闭）。 该参数数值不接受小数点， 如 1.5h，可转换为 90m。 默认值为15d。 注： 1. 如果已经和支付宝约定要求子订单明细必须同时支付成功或者同时支付失败，则不需要填入该字段。 2. time_expire和timeout_express两者只需传入一个或者都不传，两者均传入时，优先使用time_expire。
        /// </summary>
        [XmlElement("timeout_express")]
        public string TimeoutExpress { get; set; }
    }
}
