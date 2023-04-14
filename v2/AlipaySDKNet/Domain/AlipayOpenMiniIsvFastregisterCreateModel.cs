using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniIsvFastregisterCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniIsvFastregisterCreateModel : AopObject
    {
        /// <summary>
        /// 小程序名称，昵称半自动设定，强制后缀“的试用小程序”。且该参数会进行关键字检查，如果命中品牌关键字则会报错。 如遇到品牌大客户要用试用小程序，建议用户先换个名字，认证后再修改成品牌名。
        /// </summary>
        [XmlElement("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 授权确认成功后回调h5链接或小程序页面
        /// </summary>
        [XmlElement("auth_notify_url")]
        public string AuthNotifyUrl { get; set; }

        /// <summary>
        /// 外部订单号
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 商户2088
        /// </summary>
        [XmlElement("uid")]
        public string Uid { get; set; }
    }
}
