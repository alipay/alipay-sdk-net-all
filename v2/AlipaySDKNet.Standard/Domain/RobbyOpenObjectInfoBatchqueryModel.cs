using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RobbyOpenObjectInfoBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class RobbyOpenObjectInfoBatchqueryModel : AopObject
    {
        /// <summary>
        /// 业务编号，如订单号
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("biz_object_no_list")]
        [XmlArrayItem("string")]
        public List<string> BizObjectNoList { get; set; }

        /// <summary>
        /// 查询的业务对象标识所属对象库ID
        /// </summary>
        [XmlElement("object_library_id")]
        public string ObjectLibraryId { get; set; }
    }
}
