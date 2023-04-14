using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundBailOrderQueryResponse.
    /// </summary>
    public class AlipayFundBailOrderQueryResponse : AopResponse
    {
        /// <summary>
        /// 保证金预授权号
        /// </summary>
        [XmlElement("auth_no")]
        public string AuthNo { get; set; }

        /// <summary>
        /// 当result_code为FAIL时，对应的错误码
        /// </summary>
        [XmlElement("biz_error")]
        public string BizError { get; set; }

        /// <summary>
        /// 资金托管模式，网商模式下返回ANTBANK，余额模式下不返回该字段
        /// </summary>
        [XmlElement("fund_entrust_type")]
        public string FundEntrustType { get; set; }

        /// <summary>
        /// 保证金主单创建时间，格式YYYY-MM-DD HH:MM:SS
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 保证金主单最后修改时间，格式YYYY-MM-DD HH:MM:SS
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 保证金主单状态，INIT：初始态，AUTHORIZED：已预授权态。
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 订单标题
        /// </summary>
        [XmlElement("order_title")]
        public string OrderTitle { get; set; }

        /// <summary>
        /// 保证金主单的外部订单号
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 保证金产品码，固定BAIL_AUTH
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 保证金剩余可用余额
        /// </summary>
        [XmlElement("rest_amount")]
        public string RestAmount { get; set; }

        /// <summary>
        /// 返回结果码。SUCCESS：查询成功。FAIL：查询失败。
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 请求失败时，返回的错误描述
        /// </summary>
        [XmlElement("result_message")]
        public string ResultMessage { get; set; }

        /// <summary>
        /// 场景码
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }
    }
}
