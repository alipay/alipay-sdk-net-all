using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceCityfacilitatorNamelistSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceCityfacilitatorNamelistSyncModel : AopObject
    {
        /// <summary>
        /// 设备biztid
        /// </summary>
        [XmlElement("biz_tid")]
        public string BizTid { get; set; }

        /// <summary>
        /// 黑名单的p的id
        /// </summary>
        [XmlElement("partner_block_id")]
        public string PartnerBlockId { get; set; }

        /// <summary>
        /// 黑名单原因
        /// </summary>
        [XmlElement("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// 备注信息
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 黑、白属性
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 加黑原因的一些code
        /// </summary>
        [XmlElement("type_sub_code")]
        public string TypeSubCode { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("user_block_id")]
        public string UserBlockId { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("user_open_id")]
        public string UserOpenId { get; set; }
    }
}
