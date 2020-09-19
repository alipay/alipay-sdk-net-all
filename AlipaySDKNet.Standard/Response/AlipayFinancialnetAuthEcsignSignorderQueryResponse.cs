using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFinancialnetAuthEcsignSignorderQueryResponse.
    /// </summary>
    public class AlipayFinancialnetAuthEcsignSignorderQueryResponse : AopResponse
    {
        /// <summary>
        /// 附加信息
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 签约单状态
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 签约标的唯一号
        /// </summary>
        [XmlElement("sign_order_no")]
        public string SignOrderNo { get; set; }

        /// <summary>
        /// 签约产品码
        /// </summary>
        [XmlElement("sign_product_id")]
        public string SignProductId { get; set; }

        /// <summary>
        /// 签约方案码
        /// </summary>
        [XmlElement("solution_code")]
        public string SolutionCode { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 核身VID，核身结果
        /// </summary>
        [XmlElement("verify_result")]
        public string VerifyResult { get; set; }
    }
}
