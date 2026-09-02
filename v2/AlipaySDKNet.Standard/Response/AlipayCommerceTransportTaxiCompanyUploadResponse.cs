using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportTaxiCompanyUploadResponse.
    /// </summary>
    public class AlipayCommerceTransportTaxiCompanyUploadResponse : AopResponse
    {
        /// <summary>
        /// 导入失败条数
        /// </summary>
        [XmlElement("fail_count")]
        public long FailCount { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("fail_items")]
        [XmlArrayItem("import_fail_item")]
        public List<ImportFailItem> FailItems { get; set; }

        /// <summary>
        /// 成功导入数量
        /// </summary>
        [XmlElement("success_count")]
        public long SuccessCount { get; set; }
    }
}
