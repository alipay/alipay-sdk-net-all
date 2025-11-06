using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMsaasMediarecogMmportalPtcnewgoodsapplySyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMsaasMediarecogMmportalPtcnewgoodsapplySyncModel : AopObject
    {
        /// <summary>
        /// 行业同步的商品自助上新申请表入参
        /// </summary>
        [XmlArray("list")]
        [XmlArrayItem("ptc_new_goods_apply_request_vo")]
        public List<PtcNewGoodsApplyRequestVo> List { get; set; }
    }
}
