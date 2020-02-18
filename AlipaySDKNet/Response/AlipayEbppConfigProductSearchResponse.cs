using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppConfigProductSearchResponse.
    /// </summary>
    public class AlipayEbppConfigProductSearchResponse : AopResponse
    {
        /// <summary>
        /// 出账机构简称例如杭州电力的简称为HZELECTRIC
        /// </summary>
        [XmlElement("charge_inst")]
        public string ChargeInst { get; set; }

        /// <summary>
        /// 销账机构英文简称
        /// </summary>
        [XmlElement("chargeoff_inst")]
        public string ChargeoffInst { get; set; }

        /// <summary>
        /// 错误码，查询失败的返回码
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误信息描述，如参数不合法
        /// </summary>
        [XmlElement("error_message")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 输入域模型列表inputFieldList
        /// </summary>
        [XmlArray("input_field_list")]
        [XmlArrayItem("input_field_model")]
        public List<InputFieldModel> InputFieldList { get; set; }

        /// <summary>
        /// 是否成功，true或者false
        /// </summary>
        [XmlElement("is_success")]
        public string IsSuccess { get; set; }
    }
}
