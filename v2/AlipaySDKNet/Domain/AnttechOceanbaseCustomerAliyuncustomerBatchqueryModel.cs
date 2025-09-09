using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseCustomerAliyuncustomerBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseCustomerAliyuncustomerBatchqueryModel : AopObject
    {
        /// <summary>
        /// 阿里云用户id列表
        /// </summary>
        [XmlArray("user_id_list")]
        [XmlArrayItem("string")]
        public List<string> UserIdList { get; set; }
    }
}
