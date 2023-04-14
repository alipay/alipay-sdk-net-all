using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RoyaltyInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class RoyaltyInfoDTO : AopObject
    {
        /// <summary>
        /// 分账明细的信息，可以描述多条分账指令，json数组。
        /// </summary>
        [XmlElement("royalty_detail_infos")]
        public RoyaltyDetailInfoDTO RoyaltyDetailInfos { get; set; }

        /// <summary>
        /// 分账类型 卖家的分账类型，目前只支持传入ROYALTY（普通分账类型）
        /// </summary>
        [XmlElement("royalty_type")]
        public string RoyaltyType { get; set; }
    }
}
