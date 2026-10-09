using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundTransOperatorBindQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundTransOperatorBindQueryModel : AopObject
    {
        /// <summary>
        /// 业务场景码，默认DEFAULT
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 企业支付宝主账号openid
        /// </summary>
        [XmlElement("master_open_id")]
        public string MasterOpenId { get; set; }

        /// <summary>
        /// 企业支付宝主账号
        /// </summary>
        [XmlElement("master_user_id")]
        public string MasterUserId { get; set; }

        /// <summary>
        /// 操作员支付宝账号openid
        /// </summary>
        [XmlElement("operator_open_id")]
        public string OperatorOpenId { get; set; }

        /// <summary>
        /// 操作员支付宝账号
        /// </summary>
        [XmlElement("operator_user_id")]
        public string OperatorUserId { get; set; }

        /// <summary>
        /// 业务产品码，枚举： salary_platform_daily_salary
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}
