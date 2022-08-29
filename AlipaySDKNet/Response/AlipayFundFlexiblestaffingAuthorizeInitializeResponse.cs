using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundFlexiblestaffingAuthorizeInitializeResponse.
    /// </summary>
    public class AlipayFundFlexiblestaffingAuthorizeInitializeResponse : AopResponse
    {
        /// <summary>
        /// 灵工授权场景码
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 授权编码值，根据输入的code_type决定具体内容，比如initialize_code_type为SHORT_URL时，返回https短链；为PAGE_PARAM时返回用于跳转小程序的页面参数
        /// </summary>
        [XmlElement("initialize_code")]
        public string InitializeCode { get; set; }

        /// <summary>
        /// 授权编码类型，有限枚举：1. SHORT_URL 2.PAGE_PARAM
        /// </summary>
        [XmlElement("initialize_code_type")]
        public string InitializeCodeType { get; set; }

        /// <summary>
        /// 外部业务号，和接口输入的外部单号保持一致
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 灵工授权产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}
