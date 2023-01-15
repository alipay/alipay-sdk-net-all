using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbasePassaccountBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbasePassaccountBatchqueryModel : AopObject
    {
        /// <summary>
        /// 通行证账号名称列表
        /// </summary>
        [XmlArray("account_names")]
        [XmlArrayItem("string")]
        public List<string> AccountNames { get; set; }

        /// <summary>
        /// 通行证id列表
        /// </summary>
        [XmlArray("passport_ids")]
        [XmlArrayItem("string")]
        public List<string> PassportIds { get; set; }
    }
}
