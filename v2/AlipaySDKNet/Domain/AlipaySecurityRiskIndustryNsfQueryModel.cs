using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityRiskIndustryNsfQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityRiskIndustryNsfQueryModel : AopObject
    {
        /// <summary>
        /// 终端唯一标识
        /// </summary>
        [XmlElement("apdid")]
        public string Apdid { get; set; }

        /// <summary>
        /// 银行卡号，如无法提供，可填写为空值（null）
        /// </summary>
        [XmlElement("bank_card_no")]
        public string BankCardNo { get; set; }

        /// <summary>
        /// 风险咨询方所属的行业类目
        /// </summary>
        [XmlElement("business_code")]
        public string BusinessCode { get; set; }

        /// <summary>
        /// 用于输入用户的身份证 号码。如无法提供，可填写为空值（null）
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 区分咨询渠道，通过哪个平台/业务接入的咨询服务
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 城市编码；请按照https://gw.alipayobjects.com/os/basement_prod/253c4dcb-b8a4-4a1e-8be2-79e191a9b6db.xlsx 表格中内容填写。 （参考资料： http://www.stats.gov.cn/tjsj/tjbz/tjyqhdmhcxhfdm/）
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 区域编码；请按照https://gw.alipayobjects.com/os/basement_prod/253c4dcb-b8a4-4a1e-8be2-79e191a9b6db.xlsx 表格中内容填写。 （参考资料： http://www.stats.gov.cn/tjsj/tjbz/tjyqhdmhcxhfdm/）
        /// </summary>
        [XmlElement("district_code")]
        public string DistrictCode { get; set; }

        /// <summary>
        /// 邮箱账号，如无法提供，可填写为空值（null）
        /// </summary>
        [XmlElement("email_address")]
        public string EmailAddress { get; set; }

        /// <summary>
        /// 手机序列号，如无法提供，可填写为空值（null）
        /// </summary>
        [XmlElement("imei")]
        public string Imei { get; set; }

        /// <summary>
        /// 国际移动用户识别码，如无法提供，可填写为空值（null）
        /// </summary>
        [XmlElement("imsi")]
        public string Imsi { get; set; }

        /// <summary>
        /// 账户登录IP，如无法提供，可填写为空值（null）
        /// </summary>
        [XmlElement("ip")]
        public string Ip { get; set; }

        /// <summary>
        /// 是否为内部员工
        /// </summary>
        [XmlElement("is_employee")]
        public string IsEmployee { get; set; }

        /// <summary>
        /// 服务商pid
        /// </summary>
        [XmlElement("isv_pid")]
        public string IsvPid { get; set; }

        /// <summary>
        /// 用于输入用户产生交易时的地理位置信息。如参数无法提供，请填写“null”
        /// </summary>
        [XmlElement("lbs")]
        public string Lbs { get; set; }

        /// <summary>
        /// mac地址或设备唯一标识，如无法提供，可填写为空值（null）
        /// </summary>
        [XmlElement("mac_address")]
        public string MacAddress { get; set; }

        /// <summary>
        /// 收货地址
        /// </summary>
        [XmlElement("mailing_address")]
        public string MailingAddress { get; set; }

        /// <summary>
        /// 收货手机号
        /// </summary>
        [XmlElement("mailing_phone")]
        public string MailingPhone { get; set; }

        /// <summary>
        /// 支付宝商家id : 事件属性-merPid 字段说明：如果风险咨询对象是支付宝商家，则填写pid
        /// </summary>
        [XmlElement("mer_pid")]
        public string MerPid { get; set; }

        /// <summary>
        /// 风险咨询类型：01：普惠版；02：RL邀请；默认传01；
        /// </summary>
        [XmlElement("merchant_scene")]
        public string MerchantScene { get; set; }

        /// <summary>
        /// 用于输入用户注册支付宝的手机号码。如参数无法提供，请填写“null”
        /// </summary>
        [XmlElement("mobile_no")]
        public string MobileNo { get; set; }

        /// <summary>
        /// 支付宝用户openid
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 对方小程序appid
        /// </summary>
        [XmlElement("opposing_appid")]
        public string OpposingAppid { get; set; }

        /// <summary>
        /// 订单商品数量明细
        /// </summary>
        [XmlArray("order_items_info")]
        [XmlArrayItem("riskpluscore_risk_query_order_info")]
        public List<RiskpluscoreRiskQueryOrderInfo> OrderItemsInfo { get; set; }

        /// <summary>
        /// 支付宝内部交易号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 支付宝外部交易号
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 门店地址；不需要传城市和行政区
        /// </summary>
        [XmlElement("outlet_address")]
        public string OutletAddress { get; set; }

        /// <summary>
        /// 省编码；请按照https://gw.alipayobjects.com/os/basement_prod/253c4dcb-b8a4-4a1e-8be2-79e191a9b6db.xlsx 表格中内容填写。 （参考资料： http://www.stats.gov.cn/tjsj/tjbz/tjyqhdmhcxhfdm/）
        /// </summary>
        [XmlElement("province_code")]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// 用于代表商户风险类型，请按示例值填写
        /// </summary>
        [XmlElement("risk_type")]
        public string RiskType { get; set; }

        /// <summary>
        /// 填写风险咨询中对应的商户或服务商对于蚂蚁的类型
        /// </summary>
        [XmlElement("role")]
        public string Role { get; set; }

        /// <summary>
        /// 风险咨询对应的自身业务场景/环节
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 用户匹配服务类型, 请按照示例值填写
        /// </summary>
        [XmlElement("service")]
        public string Service { get; set; }

        /// <summary>
        /// 用户购买或使用服务时产生的具体金额。如参数无法提供，请填写“null”
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 用户购买或使用服务时产生的具体商品数量。如参数无法提供，请填写“null”
        /// </summary>
        [XmlElement("total_quantity")]
        public string TotalQuantity { get; set; }

        /// <summary>
        /// 用于输入用户支付宝的 2088 账号，如不了解此字段如何获取，可了解下静默授权。如参数无法提供，请填写“null”
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 用户姓名
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }
    }
}
