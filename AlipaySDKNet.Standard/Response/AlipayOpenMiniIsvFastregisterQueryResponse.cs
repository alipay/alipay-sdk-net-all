using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniIsvFastregisterQueryResponse.
    /// </summary>
    public class AlipayOpenMiniIsvFastregisterQueryResponse : AopResponse
    {
        /// <summary>
        /// 小程序应用名
        /// </summary>
        [XmlElement("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// appid
        /// </summary>
        [XmlElement("isv_app_id")]
        public string IsvAppId { get; set; }

        /// <summary>
        /// 小程序appid
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 代创建试用小程序单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 商户传入的外部订单号
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 试用小程序状态，PRECREATE 待授权确认 PROCESS 已授权使用中 SUCCESS 已转正 FAILED 已失败
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
