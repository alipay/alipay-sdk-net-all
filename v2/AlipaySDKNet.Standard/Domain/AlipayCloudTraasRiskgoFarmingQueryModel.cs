using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudTraasRiskgoFarmingQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudTraasRiskgoFarmingQueryModel : AopObject
    {
        /// <summary>
        /// 可填入活动id唯一值，或其他活动信息
        /// </summary>
        [XmlElement("activity_info")]
        public string ActivityInfo { get; set; }

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
        /// 公司名称
        /// </summary>
        [XmlElement("company_name")]
        public string CompanyName { get; set; }

        /// <summary>
        /// 小程序环境id 当前字段已废弃(不再需要环境信息，故废弃)
        /// </summary>
        [XmlElement("env_id")]
        public string EnvId { get; set; }

        /// <summary>
        /// 行业信息 当前字段已废弃(行业信息统一至business_code，不再保留该字段)
        /// </summary>
        [XmlElement("industry")]
        public string Industry { get; set; }

        /// <summary>
        /// 账户IP，如无法提供，可填写为空值（null）
        /// </summary>
        [XmlElement("ip")]
        public string Ip { get; set; }

        /// <summary>
        /// 服务商pid
        /// </summary>
        [XmlElement("isv_pid")]
        public string IsvPid { get; set; }

        /// <summary>
        /// 地理位置坐标
        /// </summary>
        [XmlElement("lbs")]
        public string Lbs { get; set; }

        /// <summary>
        /// 支付宝商家id : 事件属性-merPid 字段说明：如果风险咨询对象是支付宝商家，则填写pid
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
        /// 单位：元。用户购买商品服务时支付的总金额
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
        /// 店铺名称
        /// </summary>
        [XmlElement("store_name")]
        public string StoreName { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
