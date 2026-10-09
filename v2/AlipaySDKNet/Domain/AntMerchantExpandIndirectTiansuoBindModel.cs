using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandIndirectTiansuoBindModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandIndirectTiansuoBindModel : AopObject
    {
        /// <summary>
        /// 间连天梭绑定isv列表
        /// </summary>
        [XmlArray("tiansuo_isv_bind_list")]
        [XmlArrayItem("tiansuo_isv_bind_v_o")]
        public List<TiansuoIsvBindVO> TiansuoIsvBindList { get; set; }
    }
}
