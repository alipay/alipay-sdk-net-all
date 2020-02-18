using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ContentExtInfoModel Data Structure.
    /// </summary>
    [Serializable]
    public class ContentExtInfoModel : AopObject
    {
        /// <summary>
        /// 奖品信息
        /// </summary>
        [XmlArray("prize_info_list")]
        [XmlArrayItem("content_prize_info_model")]
        public List<ContentPrizeInfoModel> PrizeInfoList { get; set; }
    }
}
