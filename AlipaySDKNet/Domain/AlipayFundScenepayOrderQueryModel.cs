using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundScenepayOrderQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundScenepayOrderQueryModel : AopObject
    {
        /// <summary>
        /// 业务单号由场景支付业务单创建接口获得 biz_no和out_biz_no两者选其一，且out_biz_no优先
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 指定值，由支付宝侧业务提供
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 签约方账号。 当签约方类型是ALIPAY_USER_ID时，本参数为用户的支付宝账号对应的支付宝唯一用户号，以2088开头的纯16位数字； 当签约方类型是ALIPAY_LOGON_ID时，本参数为用户的支付宝登录号； 当签约方类型是ALIPAY_OPEN_ID时，本参数为用户的openId。
        /// </summary>
        [XmlElement("identity")]
        public string Identity { get; set; }

        /// <summary>
        /// 签约方类型 ALIPAY_USER_ID：表示是支付宝账号对应的支付宝唯一用户号；ALIPAY_LOGON_ID：表示是支付宝登录号；ALIPAY_OPEN_ID：表示是支付宝开放ID
        /// </summary>
        [XmlElement("identity_type")]
        public string IdentityType { get; set; }

        /// <summary>
        /// 外部业务号 该参数需搭配identity、identityType一起使用
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 固定值
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 指定值，由支付宝侧业务提供
        /// </summary>
        [XmlElement("sub_biz_scene")]
        public string SubBizScene { get; set; }
    }
}
