using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SignInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SignInfo : AopObject
    {
        /// <summary>
        /// 要跳转的页面url，如url有参数，先encode处理
        /// </summary>
        [XmlElement("back_url")]
        public string BackUrl { get; set; }

        /// <summary>
        /// 用于传输协议渲染所需内容
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 签约中心机构ID，蚂蚁签约中心分配
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 签约产品码，蚂蚁签约中心分配
        /// </summary>
        [XmlElement("sign_product_id")]
        public string SignProductId { get; set; }

        /// <summary>
        /// 签约人姓名
        /// </summary>
        [XmlElement("signer_name")]
        public string SignerName { get; set; }

        /// <summary>
        /// 签约方案码，蚂蚁签约中心分配
        /// </summary>
        [XmlElement("solution_code")]
        public string SolutionCode { get; set; }
    }
}
