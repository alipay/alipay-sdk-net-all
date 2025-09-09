using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechNftCtocTransferQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechNftCtocTransferQueryModel : AopObject
    {
        /// <summary>
        /// 业务单号
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 鲸探授权用户id(已转加密)
        /// </summary>
        [XmlElement("from_id_no")]
        public string FromIdNo { get; set; }

        /// <summary>
        /// 发起账号类型， 鲸探授权用户id(已转加密):OPEN_UID
        /// </summary>
        [XmlElement("from_id_type")]
        public string FromIdType { get; set; }

        /// <summary>
        /// 鲸探授权用户id(已转加密)
        /// </summary>
        [XmlElement("to_id_no")]
        public string ToIdNo { get; set; }

        /// <summary>
        /// 发起账号类型， 鲸探授权用户id(已转加密):OPEN_UID
        /// </summary>
        [XmlElement("to_id_type")]
        public string ToIdType { get; set; }

        /// <summary>
        /// 流转类型
        /// </summary>
        [XmlElement("transfer_type")]
        public string TransferType { get; set; }
    }
}
