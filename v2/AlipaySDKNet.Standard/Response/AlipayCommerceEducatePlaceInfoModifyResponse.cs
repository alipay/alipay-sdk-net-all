using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducatePlaceInfoModifyResponse.
    /// </summary>
    public class AlipayCommerceEducatePlaceInfoModifyResponse : AopResponse
    {
        /// <summary>
        /// 不在花名册中的学工号列表
        /// </summary>
        [XmlArray("not_exist_employee_no_list")]
        [XmlArrayItem("string")]
        public List<string> NotExistEmployeeNoList { get; set; }
    }
}
