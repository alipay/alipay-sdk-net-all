using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPayAppMarketingConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPayAppMarketingConsultModel : AopObject
    {
        /// <summary>
        /// 业务场景，用于区分商户具体的咨场景，示例： OPENING_PAGE：开屏页营销咨询； ORDER_PAGE：下单页营销咨询
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 使用morse匿名技术对原始手机号MD5值进行盲化后的结果(可通过morse工具包生成)； 若接口调用采用morse匿名方式，此字段必须与混淆后的手机号列表(confused_mobile_list)字段一起传入，二者缺一不可
        /// </summary>
        [XmlElement("blind_mobile")]
        public string BlindMobile { get; set; }

        /// <summary>
        /// 混淆后的手机号MD5值列表； 若接口调用采用morse匿名方式，此字段必须与盲化的原始手机号MD5值(blind_mobile)字段一起传入，二者缺一不可；
        /// </summary>
        [XmlArray("confused_mobile_list")]
        [XmlArrayItem("string")]
        public List<string> ConfusedMobileList { get; set; }

        /// <summary>
        /// 设备号密文，使用SHA256加密；设备号类型由device_type字段指定；（手机号、设备号或morse匿名查询，三种匹配方式至少有一种参数不能为空）
        /// </summary>
        [XmlElement("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// 设备号类型，与设备号device_id字段组合使用，默认为IMEI
        /// </summary>
        [XmlElement("device_type")]
        public string DeviceType { get; set; }

        /// <summary>
        /// 手机号md5值密文；（手机号、设备号或morse匿名查询，三种匹配方式至少有一种参数不能为空）
        /// </summary>
        [XmlElement("encrypted_mobile")]
        public string EncryptedMobile { get; set; }

        /// <summary>
        /// 已废弃不支持
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 商户订单号,64个字符以内、可包含字母、数字、下划线；需保证在商户端不重复
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 订单总金额，单位为元，精确到小数点后两位，取值范围[0.01,100000000]
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 不参与优惠计算的金额，单位为元，精确到小数点后两位，取值范围[0.01,100000000]
        /// </summary>
        [XmlElement("undiscountable_amount")]
        public string UndiscountableAmount { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
