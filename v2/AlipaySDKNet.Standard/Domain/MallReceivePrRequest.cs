using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MallReceivePrRequest Data Structure.
    /// </summary>
    [Serializable]
    public class MallReceivePrRequest : AopObject
    {
        /// <summary>
        /// app_code
        /// </summary>
        [XmlElement("app_code")]
        public string AppCode { get; set; }

        /// <summary>
        /// fix_user_id，用于下pr单
        /// </summary>
        [XmlElement("fix_user_id")]
        public string FixUserId { get; set; }

        /// <summary>
        /// 附件信息，用于下pr单
        /// </summary>
        [XmlArray("mall_files")]
        [XmlArrayItem("mall_file")]
        public List<MallFile> MallFiles { get; set; }

        /// <summary>
        /// order_items，用于下pr单
        /// </summary>
        [XmlArray("order_items")]
        [XmlArrayItem("punchout_order_item")]
        public List<PunchoutOrderItem> OrderItems { get; set; }

        /// <summary>
        /// out_pur_req_id，用于下pr单
        /// </summary>
        [XmlElement("out_pur_req_id")]
        public string OutPurReqId { get; set; }

        /// <summary>
        /// pur_req_id，用于下pr单
        /// </summary>
        [XmlElement("pur_req_id")]
        public string PurReqId { get; set; }
    }
}
