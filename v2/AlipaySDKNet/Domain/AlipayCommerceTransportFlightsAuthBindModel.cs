using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportFlightsAuthBindModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportFlightsAuthBindModel : AopObject
    {
        /// <summary>
        /// 授权码主体用于授权对象范围，当字段不为空时，表示仅授权特定航旅航司；若字段值为空，则表示一键授权所有航旅航司
        /// </summary>
        [XmlElement("auth_code")]
        public string AuthCode { get; set; }

        /// <summary>
        /// 授权场景
        /// </summary>
        [XmlElement("auth_scene")]
        public string AuthScene { get; set; }

        /// <summary>
        /// 是否自动授权
        /// </summary>
        [XmlElement("auto_auth")]
        public bool AutoAuth { get; set; }

        /// <summary>
        /// 是否取消全部场景
        /// </summary>
        [XmlElement("cancel_all")]
        public bool CancelAll { get; set; }

        /// <summary>
        /// 授权的渠道，如小程序首页：MINIAPP_HOME
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 操作类型，限定取值：binded / unbinded
        /// </summary>
        [XmlElement("operate_type")]
        public string OperateType { get; set; }

        /// <summary>
        /// 外部业务号，唯一标志本次请求
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
