using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudTraasRiskgoScalperQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudTraasRiskgoScalperQueryModel : AopObject
    {
        /// <summary>
        /// 设备唯一号码
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
        /// 证件号
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 外部会员账号
        /// </summary>
        [XmlElement("customer_id")]
        public string CustomerId { get; set; }

        /// <summary>
        /// 邮箱账号，如无法提供，可填写为空值（null）
        /// </summary>
        [XmlElement("email_address")]
        public string EmailAddress { get; set; }

        /// <summary>
        /// app所在环境信息
        /// </summary>
        [XmlElement("env_id")]
        public string EnvId { get; set; }

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
        /// 基础行业信息
        /// </summary>
        [XmlElement("industry")]
        public string Industry { get; set; }

        /// <summary>
        /// 账户IP，如无法提供，可填写为空值（null）
        /// </summary>
        [XmlElement("ip")]
        public string Ip { get; set; }

        /// <summary>
        /// 是否为员工账号
        /// </summary>
        [XmlElement("is_employee")]
        public string IsEmployee { get; set; }

        /// <summary>
        /// 服务商pid
        /// </summary>
        [XmlElement("isv_pid")]
        public string IsvPid { get; set; }

        /// <summary>
        /// 用于输入用户产生交易等节点时的地理位置信息。如参数无法提供，请填写“null”
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
        /// 收货手机号，用于区分mobile_no所填的手机号
        /// </summary>
        [XmlElement("mailing_phone")]
        public string MailingPhone { get; set; }

        /// <summary>
        /// 如果风险咨询对象是支付宝商家，则填写pid
        /// </summary>
        [XmlElement("mer_pid")]
        public string MerPid { get; set; }

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
        /// 订单商品数量（json格式描述）
        /// </summary>
        [XmlElement("order_items_info")]
        public RiskImagePlusQueryOrderInfo OrderItemsInfo { get; set; }

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
        /// 用户购买或使用服务时产生的具体金额。如参数无法提供，请填写“null”，人民币，单位：元
        /// </summary>
        [XmlElement("sales_amount")]
        public string SalesAmount { get; set; }

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
        /// 门店行业类目
        /// </summary>
        [XmlElement("store_mcc_desc")]
        public string StoreMccDesc { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
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
