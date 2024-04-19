using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// StoreInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class StoreInfoDTO : AopObject
    {
        /// <summary>
        /// 商场付场景下的商圈id
        /// </summary>
        [XmlElement("mall_id")]
        public string MallId { get; set; }

        /// <summary>
        /// 外部门店编号
        /// </summary>
        [XmlElement("real_store_id")]
        public string RealStoreId { get; set; }

        /// <summary>
        /// 交易成功后命中改商圈下的门店id列表
        /// </summary>
        [XmlArray("real_store_id_list")]
        [XmlArrayItem("string")]
        public List<string> RealStoreIdList { get; set; }
    }
}
