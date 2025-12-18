using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandEcoIotQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandEcoIotQueryModel : AopObject
    {
        /// <summary>
        /// 数组，外部业务号
        /// </summary>
        [XmlArray("out_biz_nos")]
        [XmlArrayItem("string")]
        public List<string> OutBizNos { get; set; }

        /// <summary>
        /// 分页传入的页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// sn码
        /// </summary>
        [XmlArray("sn")]
        [XmlArrayItem("string")]
        public List<string> Sn { get; set; }
    }
}
