using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMsaasMediarecogMmportalGoodsimageinfoSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMsaasMediarecogMmportalGoodsimageinfoSyncModel : AopObject
    {
        /// <summary>
        /// 对应商品主外观算法ID
        /// </summary>
        [XmlElement("algorithm_id")]
        public string AlgorithmId { get; set; }

        /// <summary>
        /// 展示图信息
        /// </summary>
        [XmlArray("img_infos")]
        [XmlArrayItem("goods_image_info")]
        public List<GoodsImageInfo> ImgInfos { get; set; }
    }
}
