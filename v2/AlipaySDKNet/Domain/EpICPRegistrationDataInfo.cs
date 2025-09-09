using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EpICPRegistrationDataInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EpICPRegistrationDataInfo : AopObject
    {
        /// <summary>
        /// 查询命中内容明细列表
        /// </summary>
        [XmlArray("hits")]
        [XmlArrayItem("ep_i_c_p_registration_info")]
        public List<EpICPRegistrationInfo> Hits { get; set; }

        /// <summary>
        /// 命中记录总数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
