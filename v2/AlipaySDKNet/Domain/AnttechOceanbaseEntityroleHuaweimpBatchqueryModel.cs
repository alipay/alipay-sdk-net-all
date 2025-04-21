using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseEntityroleHuaweimpBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseEntityroleHuaweimpBatchqueryModel : AopObject
    {
        /// <summary>
        /// 通行证id列表
        /// </summary>
        [XmlArray("passport_id_list")]
        [XmlArrayItem("string")]
        public List<string> PassportIdList { get; set; }
    }
}
