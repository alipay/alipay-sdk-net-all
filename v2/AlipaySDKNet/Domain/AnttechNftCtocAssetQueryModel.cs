using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechNftCtocAssetQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechNftCtocAssetQueryModel : AopObject
    {
        /// <summary>
        /// 授权接入令牌
        /// </summary>
        [XmlElement("access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// 鲸探授权用户id(已转加密)
        /// </summary>
        [XmlElement("id_no")]
        public string IdNo { get; set; }

        /// <summary>
        /// 账号类型
        /// </summary>
        [XmlElement("id_type")]
        public string IdType { get; set; }

        /// <summary>
        /// 上次的最后一条数据游标id
        /// </summary>
        [XmlElement("last_index")]
        public long LastIndex { get; set; }

        /// <summary>
        /// 藏品skuId列表
        /// </summary>
        [XmlArray("sku_id_list")]
        [XmlArrayItem("number")]
        public List<long> SkuIdList { get; set; }
    }
}
