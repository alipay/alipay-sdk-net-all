using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankCreditLoanapplyAmountGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditLoanapplyAmountGetModel : AopObject
    {
        /// <summary>
        /// 额度类型
        /// </summary>
        [XmlElement("biztype")]
        public string Biztype { get; set; }

        /// <summary>
        /// 额度失效时间
        /// </summary>
        [XmlElement("enddate")]
        public string Enddate { get; set; }

        /// <summary>
        /// 扩展字段 json格式
        /// </summary>
        [XmlElement("extinfo")]
        public string Extinfo { get; set; }

        /// <summary>
        /// 增加额度，单位分，必须是整数值
        /// </summary>
        [XmlElement("gainamount")]
        public string Gainamount { get; set; }

        /// <summary>
        /// 请求来源
        /// </summary>
        [XmlElement("operatesource")]
        public string Operatesource { get; set; }

        /// <summary>
        /// 请求号（幂等）
        /// </summary>
        [XmlElement("requestid")]
        public string Requestid { get; set; }

        /// <summary>
        /// 场景
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// site
        /// </summary>
        [XmlElement("site")]
        public string Site { get; set; }

        /// <summary>
        /// 支付宝userid
        /// </summary>
        [XmlElement("siteuserid")]
        public string Siteuserid { get; set; }

        /// <summary>
        /// 额度生效时间
        /// </summary>
        [XmlElement("startdate")]
        public string Startdate { get; set; }

        /// <summary>
        /// 子额度类型
        /// </summary>
        [XmlElement("subbiztype")]
        public string Subbiztype { get; set; }
    }
}
