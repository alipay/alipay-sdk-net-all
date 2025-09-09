using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechNftWithdrawBatchUnfreezeModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechNftWithdrawBatchUnfreezeModel : AopObject
    {
        /// <summary>
        /// 上游幂等单号,由博域提供
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 用户编码
        /// </summary>
        [XmlElement("id_no")]
        public string IdNo { get; set; }

        /// <summary>
        /// 用户账户类型
        /// </summary>
        [XmlElement("id_type")]
        public string IdType { get; set; }

        /// <summary>
        /// 资产列表
        /// </summary>
        [XmlArray("nft_id_set")]
        [XmlArrayItem("string")]
        public List<string> NftIdSet { get; set; }
    }
}
