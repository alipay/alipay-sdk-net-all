using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityRiskVerifyidentityApplyResponse.
    /// </summary>
    public class AlipaySecurityRiskVerifyidentityApplyResponse : AopResponse
    {
        /// <summary>
        /// 可用性查询失败错误码
        /// </summary>
        [XmlElement("err_code")]
        public string ErrCode { get; set; }

        /// <summary>
        /// 核身可用性查询错误描述
        /// </summary>
        [XmlElement("err_message")]
        public string ErrMessage { get; set; }

        /// <summary>
        /// 系统是否处理成功，true表示系统成功处理，false表示系统异常，系统处理成功不表示业务成功
        /// </summary>
        [XmlElement("is_success")]
        public string IsSuccess { get; set; }

        /// <summary>
        /// 不可用产品集合
        /// </summary>
        [XmlElement("unusable_product_list")]
        public string UnusableProductList { get; set; }

        /// <summary>
        /// 可用产品集合
        /// </summary>
        [XmlElement("usable_product_group")]
        public string UsableProductGroup { get; set; }
    }
}
