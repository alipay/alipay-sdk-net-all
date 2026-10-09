using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFinancialnetAuthEcsignUserwhitelistSaveModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFinancialnetAuthEcsignUserwhitelistSaveModel : AopObject
    {
        /// <summary>
        /// 回跳页面类型
        /// </summary>
        [XmlElement("back_type")]
        public string BackType { get; set; }

        /// <summary>
        /// 回跳页面地址
        /// </summary>
        [XmlElement("back_url")]
        public string BackUrl { get; set; }

        /// <summary>
        /// 用户手机号码，用于短信使用，可为空。
        /// </summary>
        [XmlElement("binded_mobile")]
        public string BindedMobile { get; set; }

        /// <summary>
        /// 证件号
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 外部订单号由外部系统传入
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 解决方案码由运营平台生成
        /// </summary>
        [XmlElement("solution_code")]
        public string SolutionCode { get; set; }

        /// <summary>
        /// 合同模板列表
        /// </summary>
        [XmlArray("template_vo_list")]
        [XmlArrayItem("contract_template_open_v_o")]
        public List<ContractTemplateOpenVO> TemplateVoList { get; set; }

        /// <summary>
        /// 第三方平台，签约后跳回外部app
        /// </summary>
        [XmlElement("third_part_schema")]
        public string ThirdPartSchema { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }
    }
}
