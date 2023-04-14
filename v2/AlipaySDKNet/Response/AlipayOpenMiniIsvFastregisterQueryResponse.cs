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
        /// WAIT_CONFIRM待确认创建， CONFIRM_TIMEOUT待创建确认授权超时， CREATE_MINI_APP_SUCCESS创建应用成功，CREATE_MINI_APP_FAILED创建应用失败，CANCELLED已注销，CERTIFY_SUCCESS认证成功，CERTIFY_FAILED认证失败，CERTIFY_OPERATOR管理员认证中，CERTIFY_MERCHANT法人认证中
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
