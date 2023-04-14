using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportAuthBindingGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportAuthBindingGetModel : AopObject
    {
        /// <summary>
        /// 支付宝证件类型
        /// </summary>
        [XmlElement("alipay_cert_type")]
        public string AlipayCertType { get; set; }

        /// <summary>
        /// 业务方证件类型。例如NI表示机票授权场景下的身份证类型
        /// </summary>
        [XmlElement("biz_cert_type")]
        public string BizCertType { get; set; }

        /// <summary>
        /// 证件号。证件类型对应的号码。当传入证件类型时，必须填本字段。
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型。取值枚举需要找开发人员咨询。例如IDENTITY_CARD表示身份证（已废弃，请使用biz_cert_type）
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 查询授权的渠道，如小程序首页：MINIAPP_HOME，订单同步：ORDER_SYNC
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID（对外）。当没有传证件类型时，必须传本字段。
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部业务号，唯一标志本次请求
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 授权场景，标志具体是哪种授权数据。具体取值需要找开发人员分配。例如机票行程授权场景取值为FLIGHT_SCHEDULE_PLUG_AUTH
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID。当没有传证件类型时，必须传本字段。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
