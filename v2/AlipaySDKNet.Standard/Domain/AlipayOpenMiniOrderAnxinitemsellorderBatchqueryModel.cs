using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniOrderAnxinitemsellorderBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniOrderAnxinitemsellorderBatchqueryModel : AopObject
    {
        /// <summary>
        /// 订单创建日期，格式为yyyy-MM-dd
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 小程序ID，若不指定，则以当前调用OPENAPI的小程序ID查询售卖订单
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 分页标识，第一页无须传入，上一页返回会给出
        /// </summary>
        [XmlElement("page_token")]
        public string PageToken { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
